using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text timeText;

    void Update()
    {
        /**/
        timeText.text = ScoreCounter.Instance.Timer.ToString("f0");
    }

}
