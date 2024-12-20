using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizon : MonoBehaviour
{
    public GameObject Drone;

    // Update is called once per frame
    void FixedUpdate()
    {
        float droneAnglez = Drone.transform.localEulerAngles.z;
        transform.localRotation = Quaternion.Euler(0,0, -droneAnglez);
    }
}
