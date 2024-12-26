using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RacingGates : MonoBehaviour
{
    [Header("Gates")]
    public GameObject[] Gates;
    public int ActGate;
    [Space]

    [Header("Times")]
    public float[] Times;
    public float time;
    public float pastTime;
    public float RaceTime;
    bool timerStart = false;
    [Space]

    [Header("Race")]
    bool RaceDone = false;
    [Space]

    [Header("UI")]
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

    public void StartTimer()
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
