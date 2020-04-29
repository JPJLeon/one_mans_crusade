using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileController : MonoBehaviour {

	private Rigidbody2D myRigidbody;
	private Vector3 moveDirection;
	Vector3 temporaryPosition;

	// Use this for initialization
	void Start () {
		PuntajeScript.scoreValue -= 50;
	}
	
	// Update is called once per frame
	void Update () {
		temporaryPosition = transform.position;
		temporaryPosition.x += 0.2f;
		transform.position = temporaryPosition;
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.name == "Bone Defender(Clone)" ||
			other.gameObject.name == "Bone Spearman(Clone)" ||
			other.gameObject.name == "Flag Bearer(Clone)" ||
			other.gameObject.name == "Bone Courtier(Clone)"){
			Destroy(gameObject);
		}
	}

	
}
///////////////////////////////////////////////////////////