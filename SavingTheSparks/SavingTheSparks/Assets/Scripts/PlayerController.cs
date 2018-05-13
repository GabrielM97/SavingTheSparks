using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float charge = 100;
    public float speed;
    public char dir = 'n';
    private float angle = 0;
    private float startingRotateY = 0;
    private float rotateY = 90;
    private bool paused = false;
   

    private GameObject text;

    void Start()
    {
        text = GameObject.Find("Text");
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Time.time % 2.0 < 0.01 )
        {
            charge--;
            
        }
        getCharge();


        if(angle < 1.0)
        {
            angle += 0.1f;
        }

        if(charge <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level1");
        }


    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += (gameObject.transform.forward * Time.deltaTime) * speed;
            dir = 'n';
        }
        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= (gameObject.transform.forward * Time.deltaTime) * speed;
            dir = 's';
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
        
            gameObject.transform.position += (gameObject.transform.forward * Time.deltaTime) * speed;
            dir = 'w';
            

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            
            gameObject.transform.position += (gameObject.transform.forward * Time.deltaTime) *speed;
            dir = 'e';

        }
        

        //chage direction 

        if (dir == 'w')
        {
            startingRotateY = gameObject.transform.eulerAngles.y;
            rotateY = gameObject.transform.eulerAngles.y -90;
            Debug.Log(gameObject.transform.eulerAngles.y);
            angle = 0;
            dir = 'n';

        }else if (dir == 'e')
        {
            startingRotateY = gameObject.transform.eulerAngles.y;
            rotateY = gameObject.transform.eulerAngles.y + 90;

            angle = 0;
            dir = 'n';
        }

        gameObject.transform.eulerAngles = new Vector3(0, Mathf.Lerp(startingRotateY,  rotateY, angle), 0);
    }


    public void getCharge()
    {
        text.GetComponent<Text>().text = "Charge: " + charge.ToString();
    }


    private void OnTriggerStay(Collider other)
    {

        if(other.name == "Death")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level1");
        }
        
    }


}
