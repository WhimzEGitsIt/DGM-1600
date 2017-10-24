using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject Paddle;

	private bool playing = false;
	private Vector3 PaddleToBallVector; //Distance from ball to paddle
	private Rigidbody2D rigid;


	void Start () {
		PaddleToBallVector = this.transform.position - Paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
		print (rigid);
	}



	void Update () {


		if (!playing) {
			this.transform.position = Paddle.transform.position + PaddleToBallVector;
		
			if (Input.GetMouseButtonDown(0)){
				rigid.velocity = new Vector2 (4, 20);
				playing = true;
			}
		
		
		}

	}
}
