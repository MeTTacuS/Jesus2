using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class Countdown : MonoBehaviour
{
    private Timer timer;
    private int timeLeft = 666;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        timer = new Timer(1000);
        timer.Elapsed += (System.Object source, System.Timers.ElapsedEventArgs e) => this.timeLeft--;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = timeLeft.ToString();
        if (timeLeft == 0) {
            timer.Enabled = false;
            //TODO: end game!
        }
    }
}
