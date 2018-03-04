using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed, sec, min; 
	public Text countText;
	public Text timeText;

	private Rigidbody rb; 
	private int count; 

	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		sec = 0; 
		min = 0; 
		SetCountText ();
	
		Time.timeScale = 0;

	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical"); 

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Collect")) {
			other.gameObject.SetActive (false);
			count = count + 1; 
			SetCountText ();
		}
	}

	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
	}

	void Update(){
		min = (int)(Time.time / 60f);
		sec = (int)(Time.time % 60f);
		if (count == 1) {
			timeText.text = "You win in " + min.ToString ("00") + ":" + sec.ToString ("00");
			Time.timeScale = 0;
		} else {
			timeText.text = min.ToString ("00") + ":" + sec.ToString ("00");
		}
	}
}
