using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {
	public Transform[] PatrolPoints;
	public float moveSpeed;
	private int currentPoint;

	// Use this for initialization
	void Start () {
		transform.position = PatrolPoints [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position == PatrolPoints[currentPoint].position)
		{
			currentPoint ++;
		}

		if(currentPoint >= PatrolPoints.Length)
		{
			currentPoint = 0;
		}

		transform.position = Vector3.MoveTowards(transform.position, PatrolPoints[currentPoint].position, moveSpeed* Time.deltaTime);
		transform.Rotate(0,moveSpeed*Time.deltaTime,0);
	}
}
