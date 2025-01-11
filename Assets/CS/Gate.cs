using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public RacingGates rg;
    public bool LastGate = false;
    private void OnTriggerEnter(Collider other)
    {
        //I think this is the best way
        if (LastGate)
        {
            rg.LastGate();
        }
        else
        {
            rg.NextGate();
        }
        
    }
}
