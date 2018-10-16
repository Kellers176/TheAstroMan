using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {
		
	public Button levelSelect;
		public Button startText;
		void Start () 
		{
			levelSelect = levelSelect.GetComponent<Button> ();
			startText = startText.GetComponent<Button> ();
		}

		public void StartLevel()
		{
			SceneManager.LoadScene ("Rules");
		}

		public void ExitGame()
	{
		Application.Quit ();
	}
	public void levelSelectPlay()
	{
		SceneManager.LoadScene ("LevelSelect");
	}


}
