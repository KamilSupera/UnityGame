using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Backbtn : MonoBehaviour {

	public Button backbnt; 
	// Use this for initialization
	void Start () {

		Button back = backbnt.GetComponent<Button> ();
		back.onClick.AddListener (Back);
	}

	void Back(){

		SceneManager.LoadScene ("Main", LoadSceneMode.Single);
	}
}
