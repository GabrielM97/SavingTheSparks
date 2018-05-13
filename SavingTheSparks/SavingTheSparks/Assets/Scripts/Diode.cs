using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diode : MonoBehaviour
{
    public Vector3 direction;
    private GameObject endPopup;

    void Start()
    {
        direction = transform.up;
        endPopup = GameObject.Find("EndGameText");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("DIODE TRIGGERED");
        GameObject bulbToBreak;

        if (other.tag == "Player")
        {
            other.transform.GetComponent<PlayerController>().speed = 0;

            //Break bulb
            bulbToBreak = GameObject.Find("Exploding SM_Diode-Bulb 1");
            Debug.Log(bulbToBreak.transform.GetChild(0).name);
            bulbToBreak.transform.GetChild(0).gameObject.SetActive(false);
            bulbToBreak.transform.GetChild(1).gameObject.SetActive(true);
            Debug.Log(bulbToBreak.transform.GetChild(1).name);

            

            SceneManager.LoadScene(2);
        }
    }
}