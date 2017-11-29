using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int brickCount;


	void Start(){
		brickCount = FindObjectsOfType<BlockHealth> ().Length;
		print (brickCount);
	}




	public void LevelLoad (string lvl) {
		SceneManager.LoadScene (lvl);
	}
		

	public void ExitGame () {
		print ("Tried to Exit.");
		Application.Quit ();
	}

	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex +1);
	}

	public void CheckBrickCount (){
		if (brickCount <= 0) {
			LoadNextLevel ();
		}
	}


}	