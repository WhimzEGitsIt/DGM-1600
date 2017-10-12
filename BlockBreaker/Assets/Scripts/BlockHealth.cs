using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealth : MonoBehaviour {

	public const int maxHealth = 1;
	public int currentHealth =maxHealth;

	public void TakeDamage (int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) 
		{
			currentHealth = 0;
			print ("Dead");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
