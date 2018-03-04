using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class Options : MonoBehaviour {

	public Button optionbtn; 
	// Use this for initialization
	void Start () {

		Button options = optionbtn.GetComponent<Button> ();
		options.onClick.AddListener (OptionV);
	}

	void OptionV(){

		SceneManager.LoadScene ("OptionScene", LoadSceneMode.Single);
	}
}
