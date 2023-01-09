using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        else if (other.gameObject.tag == "Scoring")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
    
    
}
