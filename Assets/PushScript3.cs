using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript3 : MonoBehaviour
{
    public KeyCode push;
    public Rigidbody rigid;
    public float x;
    public float y;
    public float z;


    void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("InRange");

            if (Input.GetKeyDown(push))
            {
                //rigid.velocity = Vector3(0,0,0);
            }
        }
    }

    private void Start()
    {

    }

    void Update()
    {
        //cube.transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);

    }
}
