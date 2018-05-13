using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimLight : MonoBehaviour
{
    public Light light;
    public bool trapped;

    void Start()
    {
        light = gameObject.GetComponent<Light>();
        trapped = true; 
    }

    // Update is called once per frame
    void Update ()
    {
        if(trapped)
        {
            Dim();
        }
    }

    private void Dim()
    {
        if (Time.time % 2.0 < 0.01)
        {
            light.intensity -= 0.05f;
        }
    }
}
