using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.R)) {
			//reloads scene where you press R
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex); 
		}
	}
}
