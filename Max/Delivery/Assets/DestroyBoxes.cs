using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoxes : MonoBehaviour
{
    public float width;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > width || transform.position.x < -width || transform.position.y > height || transform.position.y < -height)
        {
            FindObjectOfType<BoxSpawner>().SendMessage("Delivered");
            FindObjectOfType<Score>().SendMessage("Delivered");
            Destroy(gameObject);
        }
    }
}
