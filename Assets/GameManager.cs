using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    public int score;
   
    private void Awake()
    {

        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        Pause();
    }


   
   
    public void Play()
    {

        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        ball.enabled = true;
        ball.transform.position = new Vector3(-0.202f, 1.073f, 0f);



    }
    
    
    public void Pause()
    {

        Time.timeScale = 0f;
        ball.enabled = false;
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

   
}

