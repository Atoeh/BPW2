using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{
    public GameObject pauseMenu;
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    void Start()
    {
        //Cursor.LockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        if (Time.timeScale == 1f)//opzoeken naar het referencen van de bool.
        {
            //Debug.Log("Game is running and  mouse should be locked");
            MouseLookUpdate();
        }
        else
        {
            //Debug.Log("Game is paused and mouse should be free");
            Cursor.lockState = CursorLockMode.None;
        }

        
    }

    void MouseLookUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;//waarom locked hij zichzelf niet meer?
        float mouseX = Input.GetAxis("Mouse X"); //* mouseSensitivity * Time.deltaTime; //time.deltaTime zorgt ervoor dat je los van de framerate beweegt
        float mouseY = Input.GetAxis("Mouse Y"); //* mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);//in de tutporial wordt uitgelegd dat dit niet met rotate kan en alleen maar met de quaternion ofzo

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);//quaternion heeft met de rotatie te maken (naar bvn en bndn kijken)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}