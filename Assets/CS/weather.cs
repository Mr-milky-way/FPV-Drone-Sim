using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class weather : MonoBehaviour
{
    [Header("Drone")]
    public GameObject Drone;
    Rigidbody rb;
    [Space]

    [Header("Wind")]
    public float WindHeading = 0;
    public float ConstWindSpeed =  1;
    public bool windGusts;
    public float windGustSpeed;
    public float averageTimeBetwenGusts;
    Vector3 windForce;

    void Start()
    {
        rb = Drone.GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float WindHeadingRad = Mathf.Deg2Rad * WindHeading;
        if (!windGusts)
        {
            windForce = new Vector3(Mathf.Sin(WindHeadingRad * ConstWindSpeed), 0, Mathf.Cos(WindHeadingRad * ConstWindSpeed));
        } else
        {

        }
        rb.AddForce(windForce);
        transform.position = windForce;
    }
}
