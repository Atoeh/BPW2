using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    int currentTime;
    public int startingTime = 10;
    public Text timerText;
    public bool countDown = false;
    public int resetTimer = 50;
    public GameObject GameOverScreen;
    public GameObject brainBrick;
    //public float easyExtraTime

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        //timerText.GetComponent<Text>().text = "00" + currentTime;
    }

    public void dificultyEasy()
    {
        Debug.Log(" dificultyEasy");
    }

    public void dificultyMedium()
    {
        Debug.Log(" dificultyMedium");
    }

    public void dificultyHard()
    {
        Debug.Log(" dificultyMedium");
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown == false && currentTime > 0)
        {
            StartCoroutine(TimerCoroutine());
        }

        if (currentTime == 0)
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            GameOverScreen.SetActive(true);
        }
    }

    IEnumerator TimerCoroutine()
    {
        countDown = true;
        yield return new WaitForSeconds(1);
        currentTime -= 1;
        timerText.GetComponent<Text>().text = currentTime.ToString();
        countDown = false;
    }


    
   // private void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.tag == "Player")
    //    {
    //        currentTime = resetTimer;
    //        Debug.Log("triggerRestart");
    //    }
   // }
}
