using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    [Header("Camera")]
    public Camera playerCamera;
    public float currentFOV = 90f;
    public float currentAngle = 10f;
    [Space]

    [Header("UI")]
    public GameObject menu;
    public TMP_Text FOVText;
    public TMP_Text AngleText;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            menu.SetActive(true);
        }
        FOVText.text = currentFOV.ToString();
        AngleText.text = currentAngle.ToString();
    }

    public void Zoom(float zoom)
    {
        currentFOV = zoom;
        playerCamera.fieldOfView = currentFOV;
    }

    public void Angle(float Angle)
    {
        currentAngle = Angle;
        playerCamera.transform.localRotation = Quaternion.Euler(currentAngle, 0, 0);
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
