using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public Transform prefab;
    public float width;
    public float height;
    int spawn = 1;
    int delivered = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBoxes();
    }

    // Update is called once per frame
    void SpawnBoxes()
    {
        for (int i = 0; i < spawn; ++i)
        {
            Vector2 position = new Vector2(Random.Range(-width, width), Random.Range(-height, height));
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    void Delivered()
    {
        delivered++;
        if (delivered == spawn)
        {
            delivered = 0;
            spawn++;
            SpawnBoxes();
            FindObjectOfType<Timer>().SendMessage("AddTime", spawn);
        }
    }
}
