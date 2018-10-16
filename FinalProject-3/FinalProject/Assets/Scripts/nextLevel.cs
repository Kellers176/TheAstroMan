using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {
	// Use this for initialization

	bool displayMessage = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.X))
			displayMessage = false;
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		/*
		displayMessage = false;
		GameObject theCollectible = GameObject.Find ("StarPieces");
		Collectible collectible = theCollectible.GetComponent<Collectible> ();
		if (collectible.counter <= 3) {
			displayMessage = true;
		} else {
*/
			SceneManager.LoadScene ("Level2");
			//displayMessage = false;
		}
	}
/*
	void OnGUI()
	{ 
		if (displayMessage == true) {
			GUI.TextArea (new Rect (Screen.width / 2, Screen.height / 2, 200, 50), "You Need More Star Pieces. Press (x) to close");
		}

	}
	*/


