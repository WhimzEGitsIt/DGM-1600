using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject projectile;
	public Transform shotPos;


	public float movementSpeed = 5.0f;
	public float clockwise = 50.0f;
	public float counterClockwise = -50.0f;
	public float shotForce;

	void Start () {
		 
	}
	

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += Vector3.up * Time.deltaTime * movementSpeed;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += Vector3.down * Time.deltaTime * movementSpeed;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.left * Time.deltaTime * movementSpeed;
		} 
		else if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.right * Time.deltaTime * movementSpeed;
		}

		if (Input.GetKey (KeyCode.Q)) {
			transform.Rotate (0, 0, Time.deltaTime * clockwise);
		} else if (Input.GetKey (KeyCode.E)) {
			transform.Rotate (0, 0, Time.deltaTime * counterClockwise);
		}


		if (Input.GetButtonUp ("Fire1")) 
		{
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			//shot.AddFroce(shotPos.forward * shotForce);
		}
	

	}

}
