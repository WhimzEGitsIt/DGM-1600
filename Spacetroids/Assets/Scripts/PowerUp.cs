using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {


	public enum Type {fancyFeast, shield, speedBooster};
	public Type powerupType;
	public Sprite [] images;


	void Start () {
		switch (powerupType) {
		case Type.fancyFeast:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		}
	}
	

	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("We hit a powerup!");


		switch (powerupType) {
		case Type.speedBooster:
			other.GetComponent<PlayerController>().movementSpeed *= 2;
		default:
			break;
		}
		Destroy (this.gameObject);
	} 
}