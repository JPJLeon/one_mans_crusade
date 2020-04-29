using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy1, enemy2, enemy3, enemy4;
	Vector2 whereToSpawn;
	public float spawnRate = 1f;
	public float nextSpawn = 0.0f;
	private float spawnType;
	private float counter = 0.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn){
			counter += 1f;
			if(counter % 3f == 0f & spawnRate > 0.45f){
				spawnRate *= 0.9f;
			}
			nextSpawn = Time.time + spawnRate;
			whereToSpawn = new Vector2(transform.position.x, transform.position.y);
			spawnType = Random.Range(0f, 4f);

			if(spawnType <= 1){
				Instantiate (enemy1, whereToSpawn, Quaternion.identity);
			} else if(spawnType <= 2){
				Instantiate (enemy2, whereToSpawn, Quaternion.identity);
			} else if(spawnType <= 3){
				Instantiate (enemy3, whereToSpawn, Quaternion.identity);
			} else if(spawnType <= 4){
				Instantiate (enemy4, whereToSpawn, Quaternion.identity);
			} 
		}
	}
}
