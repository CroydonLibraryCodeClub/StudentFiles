using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlock : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		SendMessage("GoBackAndWait");
	}

}
