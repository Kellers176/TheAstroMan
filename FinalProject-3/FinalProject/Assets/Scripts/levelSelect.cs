using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelSelect : MonoBehaviour {

	public Button levelOne;
	public Button levelTwo;
	public Button back;
	// Use this for initialization
	void Start () {
		levelOne = levelOne.GetComponent<Button> ();
		levelTwo = levelTwo.GetComponent<Button> ();
		back = back.GetComponent<Button> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void levelOneStart()
	{
		SceneManager.LoadScene ("MainScene");

	}
	public void levelTwoStart()
	{
		SceneManager.LoadScene ("Level2");

	}
	public void goBack()
	{

		SceneManager.LoadScene ("StartGame");
	}
}
