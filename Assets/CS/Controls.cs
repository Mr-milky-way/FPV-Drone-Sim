using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class Controls : MonoBehaviour
{

    public Joys joys;

    [Header("Texts")]
    public TMP_Text Joy1;
    public TMP_Text Joy2;
    public TMP_Text Joy3;
    public TMP_Text Joy4;
    public TMP_Text Joy5;
    public TMP_Text Joy6;
    public TMP_Text Joy7;
    public TMP_Text Joy8;
    [Space]

    [Header("Dropdown")]
    public TMP_Dropdown J1;
    public TMP_Dropdown J2;
    public TMP_Dropdown J3;
    public TMP_Dropdown J4;
    public TMP_Dropdown J5;
    public TMP_Dropdown J6;
    public TMP_Dropdown J7;
    public TMP_Dropdown J8;
    [Space]

    [Header("Toggles")]
    public Toggle Joy1T;
    public Toggle Joy2T;
    public Toggle Joy3T;
    public Toggle Joy4T;
    public Toggle Joy5T;
    public Toggle Joy6T;
    public Toggle Joy7T;
    public Toggle Joy8T;
    public Toggle PsXbox;

    public void SaveToJson()
    {
        string Joys = JsonUtility.ToJson(joys);
        string filePath = Application.persistentDataPath + "/settings.json";
        File.WriteAllText(filePath, Joys);
    }

    public void LoadFromJson()
    {
        string filePath = Application.persistentDataPath + "/settings.json";
        string data = File.ReadAllText(filePath);

        joys = JsonUtility.FromJson<Joys>(data);

        GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = joys.Throtle;
        GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = joys.Pitch;
        GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = joys.Roll;
        GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = joys.Yaw;
        GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = joys.Arm;
        GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = joys.Reset;
    }

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

        if (PsXbox.isOn == true)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().ThrotleInputMin = 0;
        } else
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().ThrotleInputMin = -1;
        }
    }

    //Maping the controls
    public void J1D()
    {
        int pickedEntryIndex = J1.value;
        if (pickedEntryIndex == 1 && Joy1T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy1I";
            joys.Throtle = "joy1I";
        }
        else if (pickedEntryIndex == 2 && Joy1T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy1I";
            joys.Pitch = "joy1I";
        }
        else if (pickedEntryIndex == 3 && Joy1T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy1I";
            joys.Roll = "joy1I";
        }
        else if (pickedEntryIndex == 4 && Joy1T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy1I";
            joys.Yaw = "joy1I";
        }
        else if (pickedEntryIndex == 5 && Joy1T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy1I";
            joys.Arm = "joy1I";
        }
        else if (pickedEntryIndex == 6 && Joy1T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy1I";
            joys.Reset = "joy1I";
        }
        else if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy1";
            joys.Throtle = "joy1";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy1";
            joys.Pitch = "joy1";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy1";
            joys.Roll = "joy1";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy1";
            joys.Yaw = "joy1";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy1";
            joys.Arm = "joy1";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy1";
            joys.Reset = "joy1";
        }
    }

    public void J2D()
    {
        int pickedEntryIndex = J2.value;
        if (pickedEntryIndex == 1 && Joy2T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy2I";
            joys.Throtle = "joy2I";
        }
        else if (pickedEntryIndex == 2 && Joy2T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy2I";
            joys.Pitch = "joy2I";
        }
        else if (pickedEntryIndex == 3 && Joy2T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy2I";
            joys.Roll = "joy2I";
        }
        else if (pickedEntryIndex == 4 && Joy2T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy2I";
            joys.Yaw = "joy2I";
        }
        else if (pickedEntryIndex == 5 && Joy2T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy2I";
            joys.Arm = "joy2I";
        }
        else if (pickedEntryIndex == 6 && Joy2T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy2I";
            joys.Reset = "joy2I";
        }
        else if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy2";
            joys.Throtle = "joy2";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy2";
            joys.Pitch = "joy2";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy2";
            joys.Roll = "joy2";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy2";
            joys.Yaw = "joy2";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy2";
            joys.Arm = "joy2";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy2";
            joys.Reset = "joy2";
        }
    }

    public void J3D()
    {
        int pickedEntryIndex = J3.value;
        if (pickedEntryIndex == 1 && Joy3T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy3I";
            joys.Throtle = "joy3I";
        }
        else if (pickedEntryIndex == 2 && Joy3T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy3I";
            joys.Pitch = "joy3I";
        }
        else if (pickedEntryIndex == 3 && Joy3T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy3I";
            joys.Roll = "joy3I";
        }
        else if (pickedEntryIndex == 4 && Joy3T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy3I";
            joys.Yaw = "joy3I";
        }
        else if (pickedEntryIndex == 5 && Joy3T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy3I";
            joys.Arm = "joy3I";
        }
        else if (pickedEntryIndex == 6 && Joy3T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy3I";
            joys.Reset = "joy3I";
        }
        else if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy3";
            joys.Throtle = "joy3";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy3";
            joys.Pitch = "joy3";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy3";
            joys.Roll = "joy3";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy3";
            joys.Yaw = "joy3";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy3";
            joys.Arm = "joy3";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy3";
            joys.Reset = "joy3";
        }
    }

    public void J4D()
    {
        int pickedEntryIndex = J4.value;
        if (pickedEntryIndex == 1 && Joy4T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy4I";
            joys.Throtle = "joy4I";
        }
        else if (pickedEntryIndex == 2 && Joy4T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy4I";
            joys.Pitch = "joy4I";
        }
        else if (pickedEntryIndex == 3 && Joy4T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy4I";
            joys.Roll = "joy4I";
        }
        else if (pickedEntryIndex == 4 && Joy4T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy4I";
            joys.Yaw = "joy4I";
        }
        else if (pickedEntryIndex == 5 && Joy4T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy4I";
            joys.Arm = "joy4I";
        }
        else if (pickedEntryIndex == 6 && Joy4T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy4I";
            joys.Reset = "joy4I";
        }
        else if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy4";
            joys.Throtle = "joy4";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy4";
            joys.Pitch = "joy4";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy4";
            joys.Roll = "joy4";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy4";
            joys.Yaw = "joy4";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy4";
            joys.Arm = "joy4";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy4";
            joys.Reset = "joy4";
        }
    }

    public void J5D()
    {
        int pickedEntryIndex = J5.value;
        if (pickedEntryIndex == 1 && Joy5T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy5I";
            joys.Throtle = "joy5I";
        }
        else if (pickedEntryIndex == 2 && Joy5T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy5I";
            joys.Pitch = "joy5I";
        }
        else if (pickedEntryIndex == 3 && Joy5T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy5I";
            joys.Roll = "joy5I";
        }
        else if (pickedEntryIndex == 4 && Joy5T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy5I";
            joys.Yaw = "joy5I";
        }
        else if (pickedEntryIndex == 5 && Joy5T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy5I";
            joys.Arm = "joy5I";
        }
        else if (pickedEntryIndex == 6 && Joy5T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy5I";
            joys.Reset = "joy5I";
        }
        else if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy5";
            joys.Throtle = "joy5";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy5";
            joys.Pitch = "joy5";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy5";
            joys.Roll = "joy5";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy5";
            joys.Yaw = "joy5";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy5";
            joys.Arm = "joy5";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy5";
            joys.Reset = "joy5";
        }
    }

    public void J6D()
    {
        int pickedEntryIndex = J6.value;
        if (pickedEntryIndex == 1 && Joy6T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy6I";
            joys.Throtle = "joy6I";
        }
        else if (pickedEntryIndex == 2 && Joy6T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy6I";
            joys.Pitch = "joy6I";
        }
        else if (pickedEntryIndex == 3 && Joy6T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy6I";
            joys.Roll = "joy6I";
        }
        else if (pickedEntryIndex == 4 && Joy6T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy6I";
            joys.Yaw = "joy6I";
        }
        else if (pickedEntryIndex == 5 && Joy6T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy6I";
            joys.Arm = "joy6I";
        }
        else if (pickedEntryIndex == 6 && Joy6T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy6I";
            joys.Reset = "joy6I";
        }
        if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy6";
            joys.Throtle = "joy6";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy6";
            joys.Pitch = "joy6";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy6";
            joys.Roll = "joy6";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy6";
            joys.Yaw = "joy6";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy6";
            joys.Arm = "joy6";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy6";
            joys.Reset = "joy6";
        }
    }

    public void J7D()
    {
        int pickedEntryIndex = J7.value;
        if (pickedEntryIndex == 1 && Joy7T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy7I";
            joys.Throtle = "joy7I";
        }
        else if (pickedEntryIndex == 2 && Joy7T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy7I";
            joys.Pitch = "joy7I";
        }
        else if (pickedEntryIndex == 3 && Joy7T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy7I";
            joys.Roll = "joy7I";
        }
        else if (pickedEntryIndex == 4 && Joy7T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy7I";
            joys.Yaw = "joy7I";
        }
        else if (pickedEntryIndex == 5 && Joy7T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy7I";
            joys.Arm = "joy7I";
        }
        else if (pickedEntryIndex == 6 && Joy7T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy7I";
            joys.Reset = "joy7I";
        }
        else if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy7";
            joys.Throtle = "joy7";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy7";
            joys.Pitch = "joy7";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy7";
            joys.Roll = "joy7";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy7";
            joys.Yaw = "joy7";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy7";
            joys.Arm = "joy7";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy7";
            joys.Reset = "joy7";
        }
    }

    public void J8D()
    {
        int pickedEntryIndex = J8.value;
        if (pickedEntryIndex == 1 && Joy8T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy8I";
            joys.Throtle = "joy8I";
        }
        else if (pickedEntryIndex == 2 && Joy8T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy8I";
            joys.Pitch = "joy8I";
        }
        else if (pickedEntryIndex == 3 && Joy8T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy8I";
            joys.Roll = "joy8I";
        }
        else if (pickedEntryIndex == 4 && Joy8T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy8I";
            joys.Yaw = "joy8I";
        }
        else if (pickedEntryIndex == 5 && Joy8T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy8I";
            joys.Arm = "joy8I";
        }
        else if (pickedEntryIndex == 6 && Joy8T.isOn)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy8I";
            joys.Reset = "joy8I";
        }
        else if (pickedEntryIndex == 1)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Throtle = "joy8";
            joys.Throtle = "joy8";
        }
        else if (pickedEntryIndex == 2)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Pitch = "joy8";
            joys.Pitch = "joy8";
        }
        else if (pickedEntryIndex == 3)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Roll = "joy8";
            joys.Roll = "joy8";
        }
        else if (pickedEntryIndex == 4)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Yaw = "joy8";
            joys.Yaw = "joy8";
        }
        else if (pickedEntryIndex == 5)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Arm = "joy8";
            joys.Arm = "joy8";
        }
        else if (pickedEntryIndex == 6)
        {
            GameObject.Find("Drone").GetComponent<FPV_drone>().Reset = "joy8";
            joys.Reset = "joy8";
        }
    }

}

//For saving
[System.Serializable]
public class Joys
{
    public string Throtle;
    public string Pitch;
    public string Roll;
    public string Yaw;
    public string Arm;
    public string Reset;
}