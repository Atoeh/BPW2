using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeTrigger : MonoBehaviour
{
    public GameObject timer;
    public GameObject winScreen;
    //bool countDown = true;
    public float timeTillScreen = 2;

    void OnTriggerStay(Collider collider)
    {
        //ik bropeerde een timer op te stellen dat de WinScreen niet meteen in je gezicht popte, dit werkte echter niet.

        if (collider.tag == "Cube" )
        {
            Debug.Log("Reee");
            //&& countDown == false && timeTillScreen > 0
            //StartCoroutine(ScreenCoroutine());
            Time.timeScale = 0f;
            winScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

   // private void Update()
    //{
   //     if (timeTillScreen == 0)
   //     {
   //         timer.SetActive(false);
   //         winScreen.SetActive(true);
   //         Time.timeScale = 0f;
    //        Debug.Log("TimeHasStartedAgain");  
    //    }
    //}

    //IEnumerator ScreenCoroutine()
    //{
    //    countDown = true;
   //     yield return new WaitForSeconds(1);
    //    timeTillScreen -= 1;
    //    Debug.Log("SecondHasPassed");
   //     countDown = false;
   // }
}
