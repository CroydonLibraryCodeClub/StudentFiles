using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
	public float leftmax;
	public float rightmax;
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        position.x += move * speed;
        if (position.x < leftmax)
        {
			position.x = leftmax;
		}
		if (position.x > rightmax)
        {
			position.x = rightmax;
		}
        transform.position = position;
    }
}
