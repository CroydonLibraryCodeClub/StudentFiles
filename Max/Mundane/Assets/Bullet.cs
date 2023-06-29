using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float top;
    private Shooting player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.y += speed;
        transform.position = position;
        if (position.y > top)
        {
            player.SendMessage("AddAmo");
            Destroy(gameObject);
        }
    }
    void SetShooter(Shooting shooter)
    {
        player=shooter;
    }
}   
