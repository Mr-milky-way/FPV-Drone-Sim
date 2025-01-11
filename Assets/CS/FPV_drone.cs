using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPV_drone : MonoBehaviour
{

    [Header("Weather")]
    public bool isWet;
    [Header("Physics")]
    public Rigidbody Rigidbody;
    public float MaxTorque = 20;
    public float MaxThrust = 20;
    public float Mass = 1;
    public float PropwashVelow = -5;
    float Thrust = 0;
    [Space]


    [Header("Controls")]
    public ValueMap pitchMap;
    public ValueMap RollMap;
    public ValueMap YawMap;
    bool Armed = false;
    public Vector3 Spawn;
    public float ThrotleInputMin = -1;
    public string Throtle;
    public string Pitch;
    public string Roll;
    public string Yaw;
    public string Arm;
    public string Reset;
    [Space]

    [Header("Racing")]
    public bool RacingDrone;
    public int thisScene = 2;
    public RacingGates RacingGates;
    bool timerStarted = false;
    [Space]

    [Header("Animations")]
    public GameObject Prop1;
    public GameObject Prop2;
    [Space]

    [Header("UI")]
    public TMP_Text disarmed;

    private void Start()
    {
        GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 0;

    }

    void FixedUpdate()
    {
        if (Input.GetAxisRaw(Reset) < 0)
        {
            if (RacingDrone)
            {
                SceneManager.LoadScene(thisScene);
            }
            else
            {
                Respawn();
            }
        }


        Rigidbody.mass = Mass;
        Rigidbody.angularDrag = 20f;
        if (isWet)
        {
            Rigidbody.drag = 0.4f;
        } else
        {
            Rigidbody.drag = 0.1f;
        }

        if (Input.GetAxisRaw(Arm) > 0)
        {
            //Arming only alowed at about 0
            if (Armed == false && Thrust < 2)
            {
                Armed = true;
                timerStarted = true;
            }
        }
        if (Input.GetAxisRaw(Arm) < 0 && Armed == true)
        {
            Armed = false;
        }

        //Map the axies
        Thrust = 0 + ((MaxThrust - 0) / (1 - ThrotleInputMin)) * (Input.GetAxisRaw(Throtle) - ThrotleInputMin);
        float pitch = pitchMap.Map(Input.GetAxis(Pitch));
        float roll = RollMap.Map(Input.GetAxis(Roll));
        float yaw = YawMap.Map(Input.GetAxis(Yaw));

        if (Armed)
        {
            //Get rid of Disarmed Text
            disarmed.text = string.Empty;

            //make it look like the props are sping even when the thrust is at 0
            if (Thrust < 5)
            {
                Prop1.transform.Rotate(0, 5 * 7, 0);
                Prop2.transform.Rotate(0, 5 * -7, 0);
            }
            Prop1.transform.Rotate(0, Thrust * 7, 0);
            Prop2.transform.Rotate(0, Thrust * -7, 0);

            //has to be relative or it will break
            Rigidbody.AddRelativeTorque(roll * MaxTorque * Vector3.back);
            Rigidbody.AddRelativeTorque(yaw *  MaxTorque * Vector3.up);
            Rigidbody.AddRelativeTorque(pitch * MaxTorque * Vector3.right);
            Rigidbody.AddForce(transform.up * Thrust);


            if (Rigidbody.velocity.y < PropwashVelow && Input.GetAxisRaw(Throtle) > .25 && transform.up.y > .25 && Armed == true)
            {
                GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 10;
            }else
            {
                GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 0;
            }

            //Start the racing timer
            if (RacingDrone == true && timerStarted == true)
            {
                RacingGates.StartTimer();
                timerStarted = true;
            }
        }

        //bring back the Disarmed text if Disarmed
        else
        {
            disarmed.text = "DISARMED";
        }
    }

    public void Respawn()
    {
        Rigidbody.transform.SetPositionAndRotation(Spawn, Quaternion.Euler(0, 90, 0));
        Rigidbody.velocity = Vector3.zero;
    }
}