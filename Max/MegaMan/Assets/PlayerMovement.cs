using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    new public SpriteRenderer renderer;
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
        if (move < 0.0f)
        {
            renderer.flipX = true;
        }
        else
        {
            renderer.flipX = false;
        }
        position.x += move * speed * Time.deltaTime;
        transform.position = position;
    }
}
