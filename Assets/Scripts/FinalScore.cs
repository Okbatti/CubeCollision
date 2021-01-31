using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;
    public Text finalScore;

    public void Update()
    {
        finalScore.text = "ScOre : " + score.text;
    }
}
