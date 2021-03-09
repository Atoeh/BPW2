using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Timer : MonoBehaviour
{
    int currentTime;
    public int startingTime = 10;
    public Text timerText;
    public bool countDown = false;
    public int resetTimer = 50;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime; 
        //timerText.GetComponent<Text>().text = "00" + currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown == false && currentTime > 0)
        {
            StartCoroutine(TimerCoroutine());
        }
    }
     
    IEnumerator TimerCoroutine()
    {
        countDown = true;
        yield return new WaitForSeconds(1);
        currentTime -= 1;
        timerText.GetComponent<Text>().text = "00" + currentTime;
        countDown = false;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            currentTime = resetTimer;
            Debug.Log("triggerRestart");
        }
    }
}
