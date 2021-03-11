using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScreen : MonoBehaviour
{
    public GameObject inGameUI;
    public GameObject levelStartScreen;


    // Start is called before the first frame update
    void Start()
    {
        levelStartScreen.SetActive(true);
        inGameUI.SetActive(false);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start()
    {
        Time.timeScale = 1f; //verslomen of stoppen van tijd
        inGameUI.SetActive(true);
        levelStartScreen.SetActive(false);
    }
}
