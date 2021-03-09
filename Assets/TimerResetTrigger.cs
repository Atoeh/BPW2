using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerResetTrigger : MonoBehaviour
{
    public Text text;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player")
        {
            text.text = "The timer has been reset";
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
               
        }
    }
}
