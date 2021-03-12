using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PushScript2 : MonoBehaviour
{
    public KeyCode push;
    public GameObject cube;
    public Collider opposingTrigger;
    public bool triggeredOpposition = false;
    public Rigidbody cubeRigidbody;
    public Text inRangeText;

    public float smoothTime = 0.3F;

    private Vector3 velocity = Vector3.zero;


    public float x ;
    public float z ;

    //private Vector3 target = new Vector3(-10,10,-80);
    //private float speed = 10;

  void OnTriggerStay(Collider collider)  
    {

        //target = new Vector3(x, 0, z);

        if (collider.tag == "Player")
        {
            inRangeText.text = "Press e to push";

            if (Input.GetKeyDown(push))
            {
                //Debug.Log("moveYourAss");
                cube.transform.Translate(x, 0, z);
            }
        }
        else 
        {
           cubeRigidbody.constraints = RigidbodyConstraints.FreezePosition;
        }


        if (collider.tag == "Obstacle")
        {
            //triggeredOpposition = true;
            opposingTrigger.enabled = false;
        }
    }

  private void OnTriggerExit(Collider collider)
   {
        if (collider.tag == "Player")
        {
            inRangeText.text = " ";
        }

        if (collider.tag == "Obstacle")
        {
            Debug.Log("Funneee hehe");
            //triggeredOpposition = false;
            opposingTrigger.enabled = true;
        }
    }

    //Function that determines whether you can go in opposing way


    private void Start()
    {
        
    }

    void Update()
    {
       //cube.transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);

    }
}

