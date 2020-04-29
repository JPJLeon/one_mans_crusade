using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidbody;
	private Vector3 moveDirection;
	public GameObject corpse;
	Vector2 whereToSpawnCorpse;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		moveDirection = new Vector3(-1f * moveSpeed, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		myRigidbody.velocity = moveDirection;
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.name == "Player" || other.gameObject.name == "Sword Attack(Clone)" ){
			PuntajeScript.scoreValue += 200;
			whereToSpawnCorpse = new Vector2(transform.position.x, transform.position.y);
			Destroy(other.gameObject);
			Instantiate (corpse, whereToSpawnCorpse, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
