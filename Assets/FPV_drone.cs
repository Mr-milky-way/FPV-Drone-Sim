using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPV_drone : MonoBehaviour
{

    public Rigidbody Rigidbody;
    public float MaxTorque = 20;
    public float MaxThrust = 20;
    public float Thrust = 0;
    public bool Armed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Reset") < 0)
        {
            SceneManager.LoadScene(0);
        }
        Rigidbody.angularDrag = 10;
        if (Input.GetAxisRaw("Arm") < 1)
            Armed = true;
        else { Armed = false; }
        Thrust = 0 + ((MaxThrust - 0) / (1 - -1)) * (Input.GetAxisRaw("Up/down") - -1);
        float pitch = Input.GetAxis("Pitch");
        float roll = Input.GetAxis("Roll");
        float yaw = Input.GetAxis("Yaw");
        if (Armed)
        {
            Rigidbody.AddRelativeTorque(Vector3.up * MaxTorque * yaw);
            Rigidbody.AddRelativeTorque(Vector3.forward * MaxTorque * pitch);
            Rigidbody.AddRelativeTorque(Vector3.right * MaxTorque * roll);
            Rigidbody.AddForce(transform.up * Thrust);
        }
    }
}
