using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        winScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Destroy(player);
    }

}
