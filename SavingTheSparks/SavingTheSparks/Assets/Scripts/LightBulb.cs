using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    public Light light; 

	void Start ()
    {
        light = gameObject.GetComponent<Light>();
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Debug.Log("Light bulb triggered");
            light.range = 50;
            PlayerController pm = other.gameObject.GetComponent<PlayerController>();

            if(Time.time % 1 == 0)
            {
                pm.charge--;
                //Debug.Log("Player charge " + pm.charge);
            }

            if( pm.charge == 0)
            {
                light.range = 0;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        light.range = 0;
    }
}


