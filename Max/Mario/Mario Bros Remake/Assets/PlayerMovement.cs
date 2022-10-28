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
            animator.SetTrigger("Jump");
            animator.ResetTrigger("Landed");
            
        }

        float input = Input.GetAxis("Horizontal");
        transform.Translate(input * speed * Time.deltaTime, 0, 0);
        spriteRenderer.flipX=input<0;

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Landed");
        animator.ResetTrigger("Jump");
    }

}
