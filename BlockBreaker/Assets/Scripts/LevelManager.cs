using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {


	public void LevelLoad (string lvl) {
		SceneManager.LoadScene (lvl);
	}



	public void ExitGame () {
		print ("Tried to Exit.");
		Application.Quit ();
	}
}
	