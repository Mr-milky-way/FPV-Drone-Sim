using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhysicsMenu : MonoBehaviour
{
    [Header("Text")]
    public TMP_Text MassT;
    public TMP_Text TorqueT;
    public TMP_Text ThrustT;
    [Space]

    [Header("Drone")]
    public FPV_drone Drone;

    public void Mass(float Mass)
    {
        Drone.Mass = Mass;
        MassT.text = Mass.ToString();
    }
    public void MaxTorque(float MaxTorque)
    {
        Drone.MaxTorque = MaxTorque;
        TorqueT.text = MaxTorque.ToString();
    }
    public void MaxThrust(float MaxThrust)
    {
        Drone.MaxThrust = MaxThrust;
        ThrustT.text = MaxThrust.ToString();
    }
}
