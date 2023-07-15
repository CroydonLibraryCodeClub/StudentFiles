using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    new public SpriteRenderer renderer;
    public Rigidbody2D rigidbody2D;
    public float speed;
    public float jumpForce;
    bool grounded;
    public Animator animator;
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
            renderer.flipX = false;
        }
        else if (move>0.0f)
        {
            renderer.flipX = true;
        }
        position.x += move * speed * Time.deltaTime;
        transform.position = position;
        if (Input.GetKeyDown(KeyCode.X) && grounded)
        {
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
        animator.SetBool("Jumping", !grounded);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Touching {collision.collider.name}");
        grounded = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
        Debug.Log($"Leaving {collision.collider.name}");
    }
}
