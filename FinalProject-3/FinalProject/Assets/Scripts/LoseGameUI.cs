using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseGameUI : MonoBehaviour {
	private livesCounterUI myCount;
	public Button restartText;
	public Button menuText;
	void Start () 
	{
		restartText = restartText.GetComponent<Button> ();
		menuText = menuText.GetComponent<Button> ();
	}

	public void StartLevel()
	{
		SceneManager.LoadScene ("MainScene");
	}
	public void MenuLevel()
	{
		SceneManager.LoadScene ("StartGame");
	}
	public void ExitGame()
	{
		Application.Quit ();
	}

}
