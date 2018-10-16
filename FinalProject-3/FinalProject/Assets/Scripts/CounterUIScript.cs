using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CounterUIScript : MonoBehaviour
{
	int counter = 0;

	public void AddToCounter()
	{
		counter++;
		GetComponent<Text> ().text = counter.ToString ();
		//Debug.Log (counter);
	}



}
