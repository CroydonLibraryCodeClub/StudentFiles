using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public float speed = 1;
    // Start is called before the first frame update
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(0, 14f);
        }

        float input = Input.GetAxis("Horizontal");
        transform.Translate(input * speed * Time.deltaTime, 0, 0);
        animator.SetFloat("Speed", Mathf.Abs(input));
        spriteRenderer.flipX=input<0;

        
    }
}
