using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript3 : MonoBehaviour
{
    public KeyCode push;
    public float xLocation1;
    public float zLocation1;
    public bool alreadyTransformed = false;
    public GameObject cube;

    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(push))
        {
            if (alreadyTransformed == false)
            {
                cube.transform.Translate(4, 0, -4);
                alreadyTransformed = true;
            }else
            {
                cube.transform.Translate(-4, 0, 4);
                alreadyTransformed = false;
            }

            //if (Input.GetKeyDown(push))
            //{

            //    transform.localPosition = new Vector3(-16.5f, 0.75f, 41.5f);
            //    alreadyTransformed = true;
            //    Debug.Log(alreadyTransformed);

            //    if (alreadyTransformed == true)
            //       transform.localPosition = new Vector3(-16.5f, 0.75f, 37.5f);
            //       alreadyTransformed = false;
            //    }

            //}


        }
    }
}
