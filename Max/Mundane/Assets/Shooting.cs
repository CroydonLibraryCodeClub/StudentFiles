using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform prefab;
    public int bullets=2;
    private int amo;
    // Start is called before the first frame update
    void Start()
    {
        amo=bullets;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && amo > 0) 
        {
            var bullet = Instantiate (prefab, transform.position, Quaternion.identity);
            bullet.SendMessage("SetShooter", this);
            amo-=1;
        }
    }
    void AddAmo()
    {
        amo+=1;
    }
}
