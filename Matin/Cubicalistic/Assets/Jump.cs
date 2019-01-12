using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float force = 1.0f;
	Rigidbody physics;
	// Use this for initialization
	void Start () {
		physics = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			physics.AddForce(Vector3.up * force, ForceMode.Impulse);
		}
	}
}
