using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Menu : MonoBehaviour
{


    public Camera playerCamera; // Reference to the player camera [1, 2, 5]

    public float currentFOV = 60f; // Default FOV value [5, 6]
    public float currentAngle = 10f; // Default FOV value [5, 6]
    public GameObject Meun;
    public TMP_Text FOVText;
    public TMP_Text AngleText;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Meun.SetActive(true);
        }
        playerCamera.fieldOfView = currentFOV; // Update FOV based on slider value [1, 2, 5]
        playerCamera.transform.localRotation = Quaternion.Euler(currentAngle, 0, 0);
        FOVText.text = currentFOV.ToString();
        AngleText.text = currentAngle.ToString();
    }

    public void Zoom(float zoom)
    {
        currentFOV = zoom;
    }


    public void Angle(float Angle)
    {
        currentAngle = Angle;
    }
}
