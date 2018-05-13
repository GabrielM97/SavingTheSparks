using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistor : MonoBehaviour
{
    private int resistance;
    private bool triggered = false;
    void Start()
    {
        resistance = 30;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && triggered)
        {
            PlayerController pm = other.gameObject.GetComponent<PlayerController>();

            pm.charge -= resistance;

            triggered = false;
            //Debug.Log("Player charge " + pm.charge);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("RESISTOR TRIGGERED" + 30);

        triggered = true;
    }
}
