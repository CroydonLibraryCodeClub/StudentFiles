using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float speed;
	private float dir;
	public float leftmax;
	public float rightmax;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        dir=1;
    }

    // Update is called once per frame
    void Update()
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
