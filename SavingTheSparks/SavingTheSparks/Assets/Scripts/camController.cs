using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour {


    public GameObject player;
    
    private Vector3 prevplayerPos;
	// Use this for initialization
	void Start () {

        prevplayerPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        gameObject.transform.position = player.transform.position - player.transform.forward *10;
        gameObject.transform.position += new Vector3(0, 5, 0);
       

        gameObject.transform.LookAt(player.transform);
        

        prevplayerPos = player.transform.position;

        
    }

    
}
