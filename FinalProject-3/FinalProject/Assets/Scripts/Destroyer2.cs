using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer2 : MonoBehaviour {

	public GameObject gameObjectToKeep;



	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "player")
		{
			GameObject.Find ("LivesCounter").GetComponent<livesCounterUI> ().SubtractFromCounter ();
			DontDestroyOnLoad (gameObjectToKeep);
			SceneManager.LoadScene ("Level2");

		}
	}
}

