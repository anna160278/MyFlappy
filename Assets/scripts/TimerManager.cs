using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public float count = 0;
    public TextMeshProUGUI timerText;
    private float timerDelta = 0.05f;

    void Start() {
        InvokeRepeating("CountTime", 1f, timerDelta);
    }
    public void CountTime() {
        count += timerDelta;
        //timerText.text = count.ToString("F2").Replace(",", ":");
        int min = (int)count / 60;
        int sec = (int)count % 60;
        timerText.text = min.ToString() + ":" + sec.ToString();
    }
}
