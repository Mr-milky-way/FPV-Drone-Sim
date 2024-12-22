using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPV_drone : MonoBehaviour
{


    public PID rollPID;
    public PID pitchPID;
    public PID yawPID;
    public ValueMap YawMap;
    public ValueMap pitchMap;
    public ValueMap RollMap;

    public GameObject Prop1;
    public GameObject Prop2;

    public Rigidbody Rigidbody;
    [Header("Physics")]
    public float MaxTorque = 20;
    public float MaxThrust = 20;
    public float Thrust = 0;
    public bool Armed = false;
    public Vector3 Spawn;
    public Vector3 RollRate;
    public float PropwashVelow = -5;
    public string Throtle;
    public string Pitch;
    public string Roll;
    public string Yaw;
    public string Arm;
    public string Reset;
    public Vector3 PropRot;
    public bool RacingDrone;
    public int thisScene = 2;
    public RacingGates RacingGates;

    private void Start()
    {
        GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 0;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        RollRate = Rigidbody.angularVelocity * 180/Mathf.PI;
        if (Input.GetAxisRaw(Reset) < 0)
        {
            if (RacingDrone)
            {
                SceneManager.LoadScene(thisScene);
            }
            else
            {
                Rigidbody.transform.SetPositionAndRotation(Spawn, Quaternion.Euler(0, 90, 0));
                Rigidbody.velocity = Vector3.zero;
            }
        }


        Rigidbody.angularDrag = 20;

        if (Input.GetAxisRaw(Arm) > 0)
            Armed = true;
        else { Armed = false; }
        Thrust = 0 + ((MaxThrust - 0) / (1 - -1)) * (Input.GetAxisRaw(Throtle) - -1);

        float pitch = pitchMap.Map(Input.GetAxis(Pitch));
        float roll = RollMap.Map(Input.GetAxis(Roll));
        float yaw = YawMap.Map(Input.GetAxis(Yaw));





        if (Armed)
        {
            if (Thrust < 5)
            {
                Prop1.transform.Rotate(0, 5 * 4, 0);
                Prop2.transform.Rotate(0, 5 * -4, 0);
            }
            Prop1.transform.Rotate(0, Thrust * 4, 0);
            Prop2.transform.Rotate(0, Thrust * -4, 0);

            Rigidbody.AddRelativeTorque(Vector3.up * MaxTorque * yaw);
            Rigidbody.AddRelativeTorque(Vector3.back * MaxTorque * pitch);
            Rigidbody.AddRelativeTorque(-Vector3.left * MaxTorque * roll);
            Rigidbody.AddForce(transform.up * Thrust);
            if (Rigidbody.velocity.y < PropwashVelow && Input.GetAxisRaw(Throtle) > .25 && transform.up.y > .25 && Armed == true)
            {
                GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 10;
            }else
            {
                GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 0;
            }
            if (RacingDrone == true)
            {
                RacingGates.startTimer();
            }
        }
    }
}
