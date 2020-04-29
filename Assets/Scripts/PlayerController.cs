using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	private Animator anim;
	private bool attacking;
	public float attackTime;
	private float attackTimeCounter;
	public GameObject swordAttack;
	public GameObject scrollAttack;
	public GameObject diveAttack;
	public GameObject flagAttack;
	Vector2 whereToSpawnAttack;
	public GameObject tomb;
	public GameObject mainMenuButton;
	Vector2 whereToSpawnTomb;
	

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacking = false;	
	}
	
	// Update is called once per frame
	void Update () {
		if(!attacking){
			if(Input.GetKey(KeyCode.A)){
				attackTimeCounter = attackTime;
				attacking = true;
				anim.SetBool("SwordAttack", true);
				whereToSpawnAttack = new Vector2(-4.09f, -1.89f);
				Instantiate (swordAttack, whereToSpawnAttack, Quaternion.identity);
			}
			if(Input.GetKey(KeyCode.S)){
				attackTimeCounter = attackTime;
				attacking = true;
				anim.SetBool("ScrollAttack", true);
				whereToSpawnAttack = new Vector2(-4.09f, -1.89f);
				Instantiate (scrollAttack, whereToSpawnAttack, Quaternion.identity);
			}
			if(Input.GetKey(KeyCode.D)){
				attackTimeCounter = attackTime;
				attacking = true;
				anim.SetBool("DiveAttack", true);
				whereToSpawnAttack = new Vector2(-4.09f, -1.89f);
				Instantiate (diveAttack, whereToSpawnAttack, Quaternion.identity);
			}
			if(Input.GetKey(KeyCode.F)){
				attackTimeCounter = attackTime;
				attacking = true;
				anim.SetBool("FlagAttack", true);
				whereToSpawnAttack = new Vector2(-4.09f, -1.89f);
				Instantiate (flagAttack, whereToSpawnAttack, Quaternion.identity);
			}
		}
		
		if(attackTimeCounter > 0){
			attackTimeCounter -= Time.deltaTime;
		}
		if(attackTimeCounter <= 0){
			attacking = false;
			anim.SetBool("SwordAttack", false);
			anim.SetBool("ScrollAttack", false);
			anim.SetBool("FlagAttack", false);
			anim.SetBool("DiveAttack", false);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		whereToSpawnTomb = new Vector2(transform.position.x, transform.position.y);
		Instantiate (tomb, whereToSpawnTomb, Quaternion.identity);
		Destroy(gameObject);
	}
}
