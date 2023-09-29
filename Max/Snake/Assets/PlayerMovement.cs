using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 dir;
    public float pixelSize = 0.4f;
    public float speed=1;
    public float top;
    public float bottom;
    public float left;
    public float right;
    // Start is called before the first frame update
    void Start()
    {
        dir = Vector2.up * pixelSize;
        StartCoroutine(CycleUpdate());
    }

    // Update is called once per cycle
    IEnumerator CycleUpdate()
    {
        while(true)
        {
            yield return new WaitForSeconds(1/speed);
            transform.Translate(dir.x, dir.y, 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir = Vector2.left * pixelSize;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir = Vector2.up * pixelSize;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dir = Vector2.down * pixelSize;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dir = Vector2.right * pixelSize;
        }
    }
}
