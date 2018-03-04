using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartGameBNT : MonoBehaviour {

	public Button StartGame; 
	// Use this for initialization
	void Start () {
		Button start = StartGame.GetComponent<Button> ();
		start.onClick.AddListener (GameStart);

	}

	void GameStart(){


	}
	

}
