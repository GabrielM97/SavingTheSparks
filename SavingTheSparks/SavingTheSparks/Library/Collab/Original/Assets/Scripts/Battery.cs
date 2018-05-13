using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private int batteryCharge;
    private int uses; 
    
    //Init on start
	void Start ()
    {
        batteryCharge = 10;
        uses = 2; 
    }
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Battery triggered");

        if (other.tag == "Player")
        {
            PlayerController pm = other.gameObject.GetComponent<PlayerController>();

            Debug.Log(pm.charge);
            pm.charge += batteryCharge;
            uses--;

            if (uses == 0)
                batteryCharge = 0; 

            Debug.Log(pm.charge);
        }
    }
}
