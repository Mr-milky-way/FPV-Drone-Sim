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

    private void Start()
    {
        HeadLocation = GameObject.Find("HeadLocation").GetComponent<Transform>();
    }

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
            //Respawn if it is out of range
            drone.Respawn();
        }
    }
}
