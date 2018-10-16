using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlayer : MonoBehaviour {

	public GameObject target;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "planet") {

			Vector3 dir = target.transform.position - player.transform.position;
			float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg +270;
			player.transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);


		}


	}
}
