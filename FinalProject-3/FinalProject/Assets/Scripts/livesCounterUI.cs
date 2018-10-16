using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class livesCounterUI : MonoBehaviour {
	public static int counter = 3;
	// Use this for initialization
	void Start () {
	}
	void Update () {
		if (counter < 1) {
			SceneManager.LoadScene ("LoseGame");
		}
	}
	public void SubtractFromCounter()
	{
		Debug.Log (counter);
		counter--;
		//GetComponent<Text> ().text = counter.ToString ();

	}
	public void resetLives()
	{
		counter = 3;

	}
}
