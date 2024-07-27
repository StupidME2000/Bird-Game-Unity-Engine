using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playScore;
    public Text scoreText;

    [ContextMenu("Increment Score")]
    public void AddScore(int scoreToAdd)
    {
        playScore = playScore + scoreToAdd;
        scoreText.text = playScore.ToString();
    }
}
