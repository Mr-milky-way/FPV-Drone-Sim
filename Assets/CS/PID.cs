[System.Serializable]
public class PID
{
    public float pFactor, iFactor, dFactor;

    float integral;
    float previous_error;


    public PID(float pFactor, float iFactor, float dFactor)
    {
        this.pFactor = pFactor;
        this.iFactor = iFactor;
        this.dFactor = dFactor;
    }


    public float Update(float error, float timeFrame)
    {
        integral = iFactor * (integral + error * timeFrame);
        float D = dFactor * ((error - previous_error) / timeFrame);
        float P = error * pFactor;
        previous_error = error;
        return P + integral + D;
    }
}