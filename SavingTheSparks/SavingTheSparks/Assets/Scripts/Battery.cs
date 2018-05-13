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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.tag == "Player")
        {
            Debug.Log("Battery triggered");
            PlayerController pm = other.gameObject.GetComponent<PlayerController>();

            Debug.Log("Player charge " + pm.charge);
            pm.charge += batteryCharge;
            uses--;

            if (uses == 0)
                batteryCharge = 0; 

            Debug.Log("Player charge " + pm.charge);
        }
    }
}
