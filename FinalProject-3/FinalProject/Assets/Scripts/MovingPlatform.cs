using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public GameObject platform;
	public float speed = 5f;
	public Transform[] movePoints;
	Transform currentPoint;
	public int pointIndex;


	void Start(){
		currentPoint = movePoints [pointIndex];
	}
	void Update () {
		Move ();
	}

	void Move(){

		platform.transform.position = Vector2.MoveTowards (platform.transform.position, currentPoint.position, Time.deltaTime * speed);

		if (platform.transform.position == currentPoint.position) {
			pointIndex++;
			if (pointIndex == movePoints.Length) {
				pointIndex = 0;
			}
			currentPoint = movePoints [pointIndex];
		}
	}

}
