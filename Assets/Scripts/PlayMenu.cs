﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenu : MonoBehaviour {

	public GameObject Menu, Restart; 

	public void Start(){
		OnPause ();
	}
	public void OnPause(){
		Menu.SetActive (false);
		Restart.SetActive (true);
		Time.timeScale = 0;
	}

	public void UnPause(){
		Menu.SetActive (true);
		Restart.SetActive (false);
		Time.timeScale = 1;
	}


}
