using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propwash : MonoBehaviour
{
    #region Vars
    public bool propwashActive = true;


    [Range(0, 1)][SerializeField] float trauma;
    public float traumaMult = 5;
    [SerializeField] float traumaMag = 0.8f;
    [SerializeField] float traumaRotMag = 17f;
    float TimeCounter;
    #endregion


    public void PropwashActiveT()
    {
        propwashActive = true;
    }

    public void PropwashActiveF()
    {
        propwashActive = false;
    }

    #region Accessors
    public float Trauma
    {
        get
        {
            return trauma;
        }
        set
        {
            trauma = Mathf.Clamp01(value);
        }
    }
    
    #endregion


    #region Methods
    float GetFloat(float seed)
    {
        return (Mathf.PerlinNoise(seed, TimeCounter) - 0.5f) * 2;
    }

    Vector3 GetVector3()
    {
        return new Vector3(
        GameObject.Find("Menu").GetComponent<Menu>().currentAngle,
        GetFloat(10),
        GetFloat(100)
        );
    }

    private void Update()
    {
        if (propwashActive)
        {
            TimeCounter += Time.deltaTime * Mathf.Pow(trauma, 0.3f) * traumaMult;
            Vector3 newPos = GetVector3();
            //transform.localPosition = newPos;
            transform.localRotation = Quaternion.Euler(newPos.x, newPos.y * traumaRotMag * traumaMag, newPos.z * traumaRotMag * traumaMag);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(GameObject.Find("Menu").GetComponent<Menu>().currentAngle, 0, 0);
        }
    }
    #endregion
}
