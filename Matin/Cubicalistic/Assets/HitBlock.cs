using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlock : MonoBehaviour {

	Vector3 position;

	void Start()
	{
		position = transform.position;
	}

	void OnCollisionEnter(Collision collision)
	{
		transform.position = position;
	}
}
