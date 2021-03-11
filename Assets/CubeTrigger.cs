using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Cube")
        {
            print("Level Cleared");
        }
    }

}
