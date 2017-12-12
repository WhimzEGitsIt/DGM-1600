using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject projectile;
	public Transform shotPos;

	public int health;
	private int count =0;
	public LevelManager myLevelManager;

	public float movementSpeed = 100.0f;
	public float clockwise = 1.0f;
	public float counterClockwise = -1.0f;
	public float shotForce;

	void Start () {
		 
	}
	

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * Time.deltaTime * movementSpeed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector3.up * Time.deltaTime * movementSpeed);
		}
		//if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * Time.deltaTime * movementSpeed);
		//} 
		//else if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * Time.deltaTime * movementSpeed);
		//}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0, 0, Time.deltaTime * clockwise);
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, 0, Time.deltaTime * counterClockwise);
		}


		if (Input.GetButtonUp ("Fire1")) 
		{
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			//shot.AddFroce(shotPos.forward * shotForce);
		}
	

	}

	void OnCollisionEnter2D (Collision2D collider) {
		health--;
		count++;

		if (health <= 0) {
			Destroy (this.gameObject);
			myLevelManager.LevelLoad ("GameOver");
		
		}
	}
}
