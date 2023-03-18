using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = rb.position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position.y += 1;
        }
        rb.MovePosition(position);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position.y += -1;
        }
        rb.MovePosition(position);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position.x += -1;
        }
        rb.MovePosition(position);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position.x += 1;
        }
        rb.MovePosition(position);
    }
}
