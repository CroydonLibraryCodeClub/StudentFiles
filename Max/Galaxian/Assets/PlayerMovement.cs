using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
	public float leftmax;
	public float rightmax;
	public float speed;

    public Animator animator;

    new public Renderer renderer;

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

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            StartCoroutine(Explode());
        }
    }

    IEnumerator Explode()
    {
        animator.SetTrigger("Explode");
        yield return new WaitForSeconds(0.16f);
        renderer.enabled = false;
        yield return new WaitForSeconds(5.0f);
        renderer.enabled = true;

    }
}
