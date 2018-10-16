using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

		Rigidbody2D rb;
		float jumpSpeed = 500f;
		bool shouldJump = false;

		bool grounded = false;
		public LayerMask ground;

		bool doubleJump = true;

		// Use this for initialization
		void Start () {
			rb = GetComponent<Rigidbody2D> ();
		}

		// Update is called once per frame
		void Update () {
			CheckInput ();
		}

		void FixedUpdate(){
			CheckJump ();
			CheckGround ();
		}
		void CheckJump(){
			if (shouldJump) {
				Jump ();
			}
		}

		void CheckInput(){
			if (Input.GetKeyDown (KeyCode.Space) && (grounded || doubleJump)) {
				shouldJump = true;
			}
		}
		void CheckGround(){
			Collider2D col = Physics2D.OverlapCircle(transform.position, 1, ground);
			if (col == null) {
				grounded = false;
			} else {
				grounded = true;
				doubleJump = true;
			}

		}
		void Jump(){
			if (!grounded) {
				doubleJump = false;
				rb.velocity = Vector2.zero;
			} else {
				grounded = false;
			}
			shouldJump = false;
			rb.AddForce (transform.up * jumpSpeed);
		}

	}

