using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float speed;
	private float dir;
	public float leftmax;
	public float rightmax;

    public float diveNumber;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        dir=1;
        StartCoroutine(Patrol());
    }

    // Update is called once per frame
    IEnumerator Patrol()
    {
        PlayerMovement player = FindObjectOfType<PlayerMovement>();
        while (true)
        {
            Vector3 position = transform.position;
            
            position.x += speed * dir;
            
            if (position.x < leftmax)
            {
                dir = 1;
            }
            if (position.x > rightmax)
            {
                dir = -1;
            }
            
            transform.position = position;

            if (Mathf.Abs(position.x - player.transform.position.x) < diveNumber)
            {
                break;
            }

            yield return null;
        }

        StartCoroutine(Dive());
    }

    IEnumerator Dive()
    {
        while (true)
        {
            Vector3 position = transform.position;
            
            position.y -= speed;

            transform.position = position;
            
            yield return null;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Bullet"))
        {
           animator.SetTrigger("Shot");
           Destroy(gameObject, 0.16f);
        }
        
    }

}
