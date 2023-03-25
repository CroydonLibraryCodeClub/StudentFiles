using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float delay = 1f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            Vector2 position = rb.position;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                position.y += 1;
            }
            rb.MovePosition(position);

            if (Input.GetKey(KeyCode.DownArrow))
            {
                position.y += -1;
            }
            rb.MovePosition(position);

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                position.x += -1;
            }
            rb.MovePosition(position);

            if (Input.GetKey(KeyCode.RightArrow))
            {
                position.x += 1;
            }
            rb.MovePosition(position);
            timer = 0;
        }
    }
}
