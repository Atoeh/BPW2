using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    void Start()
    {
        //Cursor.LockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X"); //* mouseSensitivity * Time.deltaTime; //time.deltaTime zorgt ervoor dat je los van de framerate beweegt
        float mouseY = Input.GetAxis("Mouse Y"); //* mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);//in de tutporial wordt uitgelegd dat dit niet met rotate kan en alleen maar met de quaternion ofzo

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);//quaternion heeft met de rotatie te maken (naar bvn en bndn kijken)
        playerBody.Rotate(Vector3.up * mouseX);
       
    }
}