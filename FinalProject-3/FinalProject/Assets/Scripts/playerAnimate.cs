using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimate : MonoBehaviour {
		public float maxSpeed = 10f;
		bool facingRight = true;
		Rigidbody2D rb;

		bool grounded = false;
		public Transform groundCheck;
		float groundRadius = 0.2f;
		public LayerMask whatIsGround;
		public float jumpForce = 500f;

		//public AudioClip jumpSound;
		//private AudioSource source;

		Animator anim;


		void Awake()
		{
			//source = GetComponent<AudioSource> (); 
		}

		// Use this for initialization
		void Start () {
			rb = GetComponent<Rigidbody2D> ();
			anim = GetComponent<Animator> ();
		}

		// Update is called once per frame
		void FixedUpdate () {

			grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
			anim.SetBool ("Ground", grounded);

			anim.SetFloat ("vSpeed", rb.velocity.y);



			float move = Input.GetAxis ("Horizontal");

			anim.SetFloat ("speed", Mathf.Abs (move));

			rb.velocity = new Vector2 (move * maxSpeed, rb.velocity.y);

			if (move > 0 && !facingRight)
				Flip ();
			else if (move < 0 && facingRight)
				Flip ();
		}
		void Update()
		{
			if (grounded && Input.GetKeyDown (KeyCode.Space)) 
			{
				//source.PlayOneShot (jumpSound, 10f);
				anim.SetBool ("Ground", false);
				rb.AddForce(new Vector2(0, jumpForce));
			}



		}

		void Flip()
		{
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;

		}

}
