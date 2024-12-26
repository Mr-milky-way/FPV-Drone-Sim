using System;
using UnityEngine;

[System.Serializable]
public class PID
{
    public float pFactor, iFactor, dFactor, integralSaturation;

    float integral;
    float valueLast;
    float deriveMeasure;
    bool derivativeInitialized;


    public PID(float PFactor, float IFactor, float DFactor, float IntegralSaturation)
    {
        pFactor = PFactor;
        iFactor = IFactor;
        dFactor = DFactor;
        integralSaturation = IntegralSaturation;
    }


    public float Update(float error, float timeFrame)
    {

        float valueRateOfChange = (error - valueLast) / timeFrame;
        valueLast = error;

        if (derivativeInitialized)
        {
            deriveMeasure = -valueRateOfChange;
        }
        else
        {
            derivativeInitialized = true;
        }

        integral = iFactor * Mathf.Clamp(integral + (error * timeFrame), -integralSaturation, integralSaturation);
        float D = dFactor * deriveMeasure;
        float P = error * pFactor;
        return P + integral + D;
    }
}