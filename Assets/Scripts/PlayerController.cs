using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;

	private int count;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		winText.text = "";
		SetCountText ();
	}

	//Physics code
	void FixedUpdate() {

		float moveHori = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHori, 0.0f, moveV);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("Pick up")) {

			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	
	}
	void SetCountText() {
		
		countText.text = "Count " + count.ToString ();

		if (count == 9) {
			winText.text = "You Win";
		}
			
	}
}
