using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TombstoneController : MonoBehaviour {
	private float timeToRestart = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeToRestart -= Time.deltaTime;
		if(timeToRestart < 0f){
			SceneManager.LoadScene("menu");
		}
	}
}
