using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {
	public GameObject Playd, Created, Camera;
	private Vector3 create = new Vector3(8.5f,11f,-35.50f);
	private Vector3 play = new Vector3(-9f,38f,-10f);
	// Use this for initialization
	void Start () {
		CreateCam ();
	}

	public void  CreateCam(){
		GetComponent<Camera>().transform.position = create;
	}

	public void PlayCam(){
		GetComponent<Camera>().transform.position = play;
	}
}
