using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    private static ScoreCounter instance;
    public static ScoreCounter Instance { get => instance; }

    public int Score = 0;
    public int Seconds = 30;
    public bool Running = false;
    private float timer = 0.0f;
    /**/
    public float Timer { get { return timer; } }
    
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
            this.transform.gameObject.SetActive(false);
            timer = (float)Seconds;
            
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    /**/
    void Start()
    {
    }
    public void IncreaseScore()
    {
        this.Score += 1;
    }

    public void OnDisable()
    {
        this.Score = 0;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        
        if (this.timer <= 0)
        {
            Debug.Log("Finaaaal");
            timer = (float)Seconds;
            PlayerPrefs.SetInt("score", Score);
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("EndScene");
        }
    }
}
