using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controls : MonoBehaviour
{
    public TMP_Text Joy1;
    public TMP_Text Joy2;
    public TMP_Text Joy3;
    public TMP_Text Joy4;
    public TMP_Text Joy5;
    public TMP_Text Joy6;
    public TMP_Text Joy7;
    public TMP_Text Joy8;
    public TMP_Dropdown J1;
    public TMP_Dropdown J2;
    public TMP_Dropdown J3;
    public TMP_Dropdown J4;
    public TMP_Dropdown J5;
    public TMP_Dropdown J6;
    public TMP_Dropdown J7;
    public TMP_Dropdown J8;

    // Update is called once per frame
    void Update()
    {
        Joy1.text = "joy1:" + Input.GetAxis("joy1").ToString();
        Joy2.text = "joy2:" + Input.GetAxis("joy2").ToString();
        Joy3.text = "joy3:" + Input.GetAxis("joy3").ToString();
        Joy4.text = "joy4:" + Input.GetAxis("joy4").ToString();
        Joy5.text = "joy5:" + Input.GetAxis("joy5").ToString();
        Joy6.text = "joy6:" + Input.GetAxis("joy6").ToString();
        Joy7.text = "joy7:" + Input.GetAxis("joy7").ToString();
        Joy8.text = "joy8:" + Input.GetAxis("joy8").ToString();
    }

    public void J1D()
    {
        int pickedEntryIndex = J1.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy1";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy1";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy1";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy1";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy1";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy1";
        }
    }

    public void J2D()
    {
        int pickedEntryIndex = J2.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy2";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy2";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy2";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy2";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy2";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy2";
        }
    }

    public void J3D()
    {
        int pickedEntryIndex = J3.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy3";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy3";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy3";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy3";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy3";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy3";
        }
    }

    public void J4D()
    {
        int pickedEntryIndex = J4.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy4";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy4";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy4";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy4";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy4";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy4";
        }
    }

    public void J5D()
    {
        int pickedEntryIndex = J5.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy5";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy5";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy5";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy5";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy5";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy5";
        }
    }

    public void J6D()
    {
        int pickedEntryIndex = J6.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy6";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy6";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy6";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy6";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy6";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy6";
        }
    }

    public void J7D()
    {
        int pickedEntryIndex = J7.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy7";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy7";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy7";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy7";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy7";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy7";
        }
    }

    public void J8D()
    {
        int pickedEntryIndex = J8.value;
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy8";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy8";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy8";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy8";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy8";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy8";
        }
    }
}
