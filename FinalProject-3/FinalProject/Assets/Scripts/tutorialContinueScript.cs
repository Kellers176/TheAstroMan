using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tutorialContinueScript : MonoBehaviour {

	public Button startButton;
	// Use this for initialization
	void Start () {
		startButton = startButton.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startLevel()
	{
		SceneManager.LoadScene ("MainScene");

	}
}
