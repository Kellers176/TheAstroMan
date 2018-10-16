using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {


	livesCounterUI lives;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnLevelWasLoaded()
	{
		GameObject.Find ("LivesCounter").GetComponent<livesCounterUI> ().resetLives ();

	}
}
