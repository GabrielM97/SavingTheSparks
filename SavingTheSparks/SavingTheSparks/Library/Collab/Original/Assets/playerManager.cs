using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour {

	// Use this for initialization
    
    public  float charge = 100;
    public float speed = 2;


    private Vector3 forward = new Vector3(0.1f, 0, 0);
    private Vector3 backword = new Vector3(-0.1f, 0, 0);
    private Vector3 left = new Vector3(1f, 0, 0);
    private Vector3 right = new Vector3(-1f, 0, 0);
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += backword;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        
    }



}
