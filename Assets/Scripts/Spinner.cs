using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float turnoverRate = 90f; // w stopniach/s
    public int pulsationRate = 3;
    public float pulsAmplitude = 0.2f;
    public Vector3 initialScale;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialScale =  transform.localScale;
       //Application.targetFrameRate = 15;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, turnoverRate * Time.deltaTime, Space.World);
        float scaleFactor = 1f + Mathf.Sin(Time.time * pulsationRate) * pulsAmplitude;
        transform.localScale = initialScale * scaleFactor;
    }
}
