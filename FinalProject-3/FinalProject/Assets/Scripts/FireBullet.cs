using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

	public GameObject bulletPrefab;

	Transform bulletSpawn;



	// Use this for initialization
	void Start () {
		bulletSpawn = transform.Find ("BulletSpawn");
	}

	// Update is called once per frame
	void Update () {
		CheckInput ();
	}

	void CheckInput()
	{
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			Fire ();

		}

	}

	void Fire()
	{
		GameObject bullet = Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation) as GameObject;

	}
}
