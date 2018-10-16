using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mainMenuScript : MonoBehaviour {


	public Button mainMenuButton;
	// Use this for initialization
	void Start () {
		mainMenuButton = mainMenuButton.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void restartMenu()
	{

		SceneManager.LoadScene("StartGame");
	}
}
