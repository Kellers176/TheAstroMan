using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collectible : MonoBehaviour {
	public int counter = 0;




	void Start()
	{
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		AddssToCounter ();
		Destroy (gameObject);
	}

	void AddssToCounter()
	{
		counter++;
		Debug.Log (counter);
		GameObject.Find ("Counter").GetComponent<CounterUIScript> ().AddToCounter ();
	}


}
