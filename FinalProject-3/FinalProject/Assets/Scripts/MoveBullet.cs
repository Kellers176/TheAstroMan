using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {
		float bulletLife = 90f;
		float lifeCount = 0f;

		//public GameObject explosionPrefab;

		// Use this for initialization
		void Start () {
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 1000);
		}

		void OnCollisionEnter2D(Collision2D col)
		{
			//Instantiate (explosionPrefab, transform.position, transform.rotation);
			Destroy (gameObject);
		}


		// Update is called once per frame
		void Update () {
			CheckLife ();
		}

		void CheckLife()
		{
			lifeCount++;
			if (lifeCount == bulletLife) 
			{
				Destroy (gameObject);
			}


		}

}
