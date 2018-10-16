using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

	public List<GameObject> objectss;
	public GameObject planet;
	Rigidbody2D rb;
	public GameObject player;
	Vector3 forward;



	public float gravitationalPull;
	int speed = 4;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate()
	{
		
		if (planet.transform.position.x - this.transform.position.x < 7 && planet.transform.position.x - this.transform.position.x > -7)
		{
			//Vector3 dir = planet.transform.position - player.transform.position;
			//float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg +270;
			//player.transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);


			rb.AddForce ((planet.transform.position - transform.position) * gravitationalPull);
		} 
		else
		{
			Physics2D.gravity = new Vector3 (0f, -30f, 0f);
		}
	}
	void OnCollision2D(Collision2D col)
	{
		if (col.gameObject.tag == "ground") {
			player.transform.Rotate (0, 0, 0);

		}
	}

}

