using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;

    public int Score = 0;
    public int Seconds = 30;
    public bool Running = false;
    private float timer = 0.0f;
    private int secs;
    
    private void Awake()
    {
        if (Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void IncreaseScore()
    {
        this.Score += 1;
    }
    public void StartCounter()
    {
        if (!this.Running) {
            this.Seconds = 30;
            this.Score = 0;
            this.Running = true;
        }
    }

    void Update()
    {
        if (this.Running) 
        {
            timer += Time.deltaTime;
            secs = (int)(timer % 60);
            this.Seconds = 30 - secs;
        }

        if (this.Seconds <= 0) this.Running = false;

        if (!this.Running && this.Seconds <= 0) 
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Additive); 
        }
    }
}
