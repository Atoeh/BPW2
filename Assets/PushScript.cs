using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PushScript : MonoBehaviour
{
    public float Speed;
    public KeyCode push;
    private Rigidbody rigidbody;
    public string directionCube = "...";

    private Vector3 vectorCube;
    public Rigidbody cubeRigidbody;
    public Text inRangeText;
    void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player" )
        {
            inRangeText.text = "Press e to push";

            if (Input.GetKeyDown(push)) 
            {
                //rigidbody.velocity = collider.transform.forward * Speed; //niet de forward van de kubus maar die van de player

                //vergelijken of de x of z waarde het grootste is en cancelled de andere kracht, 
                //kijkt ook of de kracht positief of negatief is.

                if (Mathf.Abs(collider.transform.forward.x) > Mathf.Abs(collider.transform.forward.z))
                {
                    if (collider.transform.forward.x > 0) {
                        vectorCube = new Vector3(1, 0, 0);
                        //directionCube = "x";
                    } else {
                        vectorCube = new Vector3(-1, 0, 0);
                        //directionCube = "-x";
                    }
                    //Debug.Log(collider.transform.forward.x);
                } else {
                    //Debug.Log(collider.transform.forward.z);
                    if (collider.transform.forward.z > 0) {
                        vectorCube = new Vector3(0, 0, 1);
                        //directionCube = "z";
                    }
                    else {
                        vectorCube = new Vector3(0, 0, -1);
                        //directionCube = "-z";
                    }
                }
                rigidbody.velocity = vectorCube * Speed;
                //collider.transform.forward.x > collider.transform.forward.z ?
                //Debug.Log(collider.transform.forward.x) :
                // Debug.Log(collider.transform.forward.z);
            }
        }
    }

    //void OnTriggerEnter(Collider collider) 
    //{
    //    if (collider.tag == "BounceBlock")
    //    {
    //        if (directionCube == "x")
    //        {
    //            vectorCube = new Vector3(0, 0, 1);
    //            directionCube = "z";
    //        }
    //        if (directionCube == "-x")
    //        {
    //            vectorCube = new Vector3(0, 0, -1);
    //            directionCube = "-z";
    //        }
    //        if (directionCube == "z")
    //       {
    //            vectorCube = new Vector3(-1, 0, 0);
    //            directionCube = "-x";
    //        }
    //        if (directionCube == "-z")
    //        {
    ///            vectorCube = new Vector3(1, 0, 0);
    //            directionCube = "x";
    //        }
    //    }
    //}


    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            inRangeText.text = " ";
        }
        else 
        {
            if(Mathf.Abs(collider.transform.forward.x) < 1 && Mathf.Abs(collider.transform.forward.z) < 1)
            {
                //cubeRigidbody.constraints = RigidbodyConstraints.FreezePosition;
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();//referentie naar de rigidbody van de kubus
    }

    // Update is called once per frame
    void Update()
    {
        if(directionCube != "..." && Time.timeScale ==1f)
        Debug.Log(directionCube);
    }
}
