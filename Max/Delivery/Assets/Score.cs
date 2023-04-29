using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text text;
    int delivered = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Delivered()
    {
        delivered++;
        text.text = $"Delivered : {delivered}";
    }
}
