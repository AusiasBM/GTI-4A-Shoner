using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "EndScene")
        {
            scoreText.text = PlayerPrefs.GetInt("score").ToString();
        }
        else
        {
            scoreText.text = ScoreCounter.Instance.Score.ToString();
        }
        
    }

}
