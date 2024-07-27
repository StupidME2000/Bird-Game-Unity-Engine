using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playScore;
    public Text scoreText;
    public GameObject gameOverPanel;
    

    //[ContextMenu("Increment Score")]
    public void AddScore(int scoreToAdd)
    {
        playScore = playScore + scoreToAdd;
        scoreText.text = playScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        

    }
}
