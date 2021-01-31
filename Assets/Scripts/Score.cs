using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    

    public void Start()
    {
        scoreText.text = GetComponent<Text>().ToString();
        score = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        scoreText.text = score.ToString();
    }
}