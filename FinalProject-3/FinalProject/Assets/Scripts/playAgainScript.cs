using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playAgainScript : MonoBehaviour {


	public Button restartButton;
	// Use this for initialization
	void Start () {
		restartButton = restartButton.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void restartLevel()
	{
		SceneManager.LoadScene ("StartGame");

	}
}
