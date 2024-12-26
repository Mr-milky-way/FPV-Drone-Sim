using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SignalStrength : MonoBehaviour
{
    [Header("Ray Info")]
    public LayerMask mask;
    public Transform HeadLocation;
    public bool hitingOJB = false;
    [Space]

    [Header("Signal")]
    public float strength = 100;
    public float FallOff;
    public float FallOffStart;
    [Space]

    [Header("Drone")]
    public FPV_drone drone;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, HeadLocation.position);

        if (Physics.Linecast(transform.position, HeadLocation.position, mask))
        {
            hitingOJB = true;
            FallOff = FallOffStart * 2;
        } else
        {
            hitingOJB = false;
            FallOff = FallOffStart;
        }

        strength = 100 - distance * FallOff;

        if (strength <= 0)
        {
            drone.Respawn();
        }
    }
}
