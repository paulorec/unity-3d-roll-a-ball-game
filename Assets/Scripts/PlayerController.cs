using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody> ();
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
		}
	
	}
}
