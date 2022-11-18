using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    bool planeIsActive = true;
    public GameObject planeFinder;
    ScoreCounter scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = ScoreCounter.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (!planeFinder.activeInHierarchy && !scoreCounter.gameObject.activeInHierarchy) 
        {
            scoreCounter.gameObject.SetActive(true);
        }
    }
}
