using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PushScript : MonoBehaviour
{
    public float Speed;
    public KeyCode push;
    private Rigidbody rigidbody;

    private Vector3 vectorCube;

    public Text inRangeText;

    void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player")
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
                    } else {
                        vectorCube = new Vector3(-1, 0, 0);
                    }
                    Debug.Log(collider.transform.forward.x);
                } else {
                    Debug.Log(collider.transform.forward.z);
                    if (collider.transform.forward.z > 0) {
                        vectorCube = new Vector3(0, 0, 1);
                    }
                    else {
                        vectorCube = new Vector3(0, 0, -1);
                    }
                }

                rigidbody.velocity = vectorCube * Speed;

                //collider.transform.forward.x > collider.transform.forward.z ?
                //Debug.Log(collider.transform.forward.x) :
                // Debug.Log(collider.transform.forward.z);

            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            inRangeText.text = " ";
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
        
    }
}
