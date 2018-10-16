using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	float xMove;
	Rigidbody2D rb;
	float xSpeed = 5f;


	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	void Update () {
		CheckInput ();
	}
	void FixedUpdate(){
		Move ();
	}
	void Move(){
		rb.velocity = new Vector2(xMove, rb.velocity.y);
	}
	void CheckInput(){
		xMove = Input.GetAxis ("Horizontal") * xSpeed;
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "MovingPlatform") {
			transform.parent = col.transform;
		}
	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "MovingPlatform") {
			transform.parent = null;
		}
	}
}

