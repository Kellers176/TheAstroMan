using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 3f;
	int life = 50;

	void Start () {

	}
	void FixedUpdate () {


		target = GameObject.FindWithTag ("player").transform;

		Vector3 forwardAxis = new Vector3 (0, 0, -1);

		transform.LookAt (target.position, forwardAxis);
		Debug.DrawLine (transform.position, target.position);
		transform.eulerAngles = new Vector3 (0, 0, -transform.eulerAngles.z);
		transform.position -= transform.TransformDirection (Vector2.up) * speed ;
	}
	void Update(){

		//move towards the player
		if (Vector3.Distance(transform.position,target.position)>1f){//move if distance from target is greater than 1
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0) );
		}

	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "player" || col.gameObject.tag == "bullet") {
			life-=10;
			Debug.Log ("Health of Enemy: " + life);
			if (life <= 0) {
				Destroy (gameObject);
			}
		}

	}
}

