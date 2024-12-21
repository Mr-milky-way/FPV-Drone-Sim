using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPV_drone : MonoBehaviour
{

    public Rigidbody Rigidbody;
    [Header("Physics")]
    public float MaxTorque = 20;
    public float MaxThrust = 20;
    public float Thrust = 0;
    public bool Armed = false;
    public Vector3 Spawn;
    public float PropwashVelow = -5;
    public string Throtle;
    public string Pitch;
    public string Roll;
    public string Yaw;
    public string Arm;
    public string Reset;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw(Reset) < 0)
        {
            Rigidbody.transform.SetPositionAndRotation(Spawn, Quaternion.Euler(0,90,0));
            Rigidbody.velocity = Vector3.zero;
        }
        Rigidbody.angularDrag = 20;
        if (Input.GetAxisRaw(Arm) > 0)
            Armed = true;
        else { Armed = false; }
        Thrust = 0 + ((MaxThrust - 0) / (1 - -1)) * (Input.GetAxisRaw(Throtle) - -1);
        float pitch = Input.GetAxis(Pitch);
        float roll = Input.GetAxis(Roll);
        float yaw = Input.GetAxis(Yaw);
        if (Armed)
        {
            Rigidbody.AddRelativeTorque(Vector3.up * MaxTorque * yaw);
            Rigidbody.AddRelativeTorque(Vector3.back * MaxTorque * pitch);
            Rigidbody.AddRelativeTorque(-Vector3.left * MaxTorque * roll);
            Rigidbody.AddForce(transform.up * Thrust);
            if (Rigidbody.velocity.y < PropwashVelow && Input.GetAxisRaw(Throtle) > .25 && transform.up.y > .25 && Armed)
            {
                GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 10;
            }else
            {
                GameObject.Find("Camera").GetComponent<Propwash>().traumaMult = 0;
            }
        }
    }
}
