using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectRings : MonoBehaviour
{
    public int rings;
    public Text textBox;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = $"Rings {rings}";
    }

    public void AddRing(int number)
    {
        rings += number;
        audio.Play();
    }
}
