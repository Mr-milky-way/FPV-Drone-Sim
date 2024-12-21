using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public RacingGates rg;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        rg.NextGate();
    }
}
