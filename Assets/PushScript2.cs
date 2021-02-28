using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript2 : MonoBehaviour
{
    public KeyCode push;
    public GameObject cube;
    public float x = 0f;
    public float y = 0f;
    public float z = 1f;
  void OnTriggerStay(Collider collider)  
    {      
        if (collider.tag == "Player")
        {
             Debug.Log("InRange");

             if (Input.GetKeyDown(push))           
             {
                cube.transform.Translate(x, y, z);
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

