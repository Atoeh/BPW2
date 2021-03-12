using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);//maakt een sphere aan en bepaald of er iets in contact komt (vloer)
        if(isGrounded && velocity.y<0)//wanneer in contact met de grond
        {
            velocity.y = -2f;//ipv constant toenemend getal wordt de downforce verranderd tot -2f
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;// zorgt erfvoor dat de ass verranderd in de richting waarin de player kijkt

        controller.Move(move*speed*Time.deltaTime);


        velocity.y += gravity * Time.deltaTime;                 //zwaartekracht_snelheid

        controller.Move(velocity * Time.deltaTime);             //twee maal vermenigvuldigen wegens feit dat het m/s^2 is
    }
}
