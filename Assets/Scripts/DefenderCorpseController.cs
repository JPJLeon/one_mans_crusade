using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderCorpseController : MonoBehaviour {

	private float timeToDie;

	// Use this for initialization
	void Start () {
		timeToDie = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		timeToDie -= Time.deltaTime;
		if(timeToDie < 0f){
			Destroy(gameObject);
		}
	}
}
