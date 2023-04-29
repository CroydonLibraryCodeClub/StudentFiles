using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text text;
    public GameObject gameOver;
    public float timer = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        text.text = $"Timer : {timer:N0}";
        if (timer < 0.0f)
        {
            FindObjectOfType<BoxSpawner>().enabled = false;
            FindObjectOfType<PlayerMovement>().enabled = false;
            gameOver.SetActive(true);
            enabled = false;
        } 
    }

    void AddTime(int bonus)
    {
        timer += bonus;
    }
}
