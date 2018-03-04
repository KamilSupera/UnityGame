using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

	public Button btn; 
	// Use this for initialization
	void Start () {
		Button exit = btn.GetComponent<Button> ();
		exit.onClick.AddListener (Exitb);
	}

	void Exitb(){
		Application.Quit ();
	}

}
