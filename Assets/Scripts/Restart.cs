using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	public Button restart; 
	// Use this for initialization
	void Start () {
		Button re = restart.GetComponent<Button> ();
		re.onClick.AddListener (restartd);
	}

	void restartd(){ 
		SceneManager.LoadScene ("Test", LoadSceneMode.Single);
	}
}
