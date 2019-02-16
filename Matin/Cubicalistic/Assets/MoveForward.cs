using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float steer = Input.GetAxis("Horizontal");
		transform.Translate((Vector3.forward + Vector3.right * steer) * Time.deltaTime * speed);

		if (transform.position.z > 0.0f)
		{
			Vector3 position = transform.position;
			position.z -= 500.0f;
			transform.position = position;
		}
	}
}
