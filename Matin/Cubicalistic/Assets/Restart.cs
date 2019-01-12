using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
	
	public float delay = 1.0f;
	Vector3 position;
	MoveForward move;

	void Start()
	{
		position = transform.position;
		move = GetComponent<MoveForward>();
	}

	void GoBackAndWait()
	{
		transform.position = position;
		move.enabled = false;
		Invoke("StartMoving", delay);
	}

	void StartMoving()
	{
		move.enabled = true;
	}

}
