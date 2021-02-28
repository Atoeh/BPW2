using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour
{
    public float Speed;
    public KeyCode push;
    private Rigidbody rigidbody;

    void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("InRange");

            if (Input.GetKeyDown(push)) 
            {
                rigidbody.velocity = collider.transform.forward * Speed; //niet de forward van de kubus maar die van de player
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
        
    }
}
