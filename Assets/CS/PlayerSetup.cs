using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public FPV_drone Drone;

    public GameObject Camera;
    public GameObject UI;


    public void IsLocalPlayer()
    {
        Drone.enabled = true;
        Camera.SetActive(true);
        UI.SetActive(true);
    }
}
