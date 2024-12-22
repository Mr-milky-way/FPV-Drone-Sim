using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RacingGates : MonoBehaviour
{

    public GameObject[] Gates;

    public int ActGate;
    public float[] Times;
    public float time;
    public float pastTime;
    public float RaceTime;

    bool RaceDone = false;
    bool timerStart = false;

    public TMP_Text timeText;

    void Update()
    {
        if (timerStart ==  true)
        {
            time = pastTime + Time.deltaTime;
            pastTime = time;
        }
        if (RaceDone)
        {
            timeText.text = RaceTime.ToString();
        }
        else
        {
            timeText.text = time.ToString();
        }
    }

    public void startTimer()
    {
        timerStart = true;
    }

    public void NextGate()
    {
        Times[ActGate] = time;
        ActGate++;
        Gates[ActGate - 1].SetActive(false);
        Gates[ActGate].SetActive(true);

    }

    public void LastGate()
    {
        RaceTime = time;
        Gates[ActGate].SetActive(false);
        RaceDone = true;
    }
}
