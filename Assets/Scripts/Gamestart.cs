using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Gamestart : MonoBehaviour {

	public Button startbtn; 
	// Use this for initialization
	void Start () {
		
		Time.timeScale = 0;
		Button start = startbtn.GetComponent<Button> ();
		start.onClick.AddListener (Startg);
	}

	void Startg(){

		SceneManager.LoadScene ("Test", LoadSceneMode.Single);
	}
}
