using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingGates : MonoBehaviour
{

    public GameObject[] Gates;

    public int ActGate;
    public float[] Times;
    public float time;
    public float pastTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time= pastTime + Time.deltaTime;
        pastTime = time;

        Gates[ActGate].SetActive(true);
    }

    public void NextGate()
    {
        Times[ActGate] = time;
        ActGate++;
        Gates[ActGate - 1].SetActive(false);
        
    }
}
