using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController:MonoBehaviour
{
    private CharacterController controller;

    [SerializeField]
    private Vector3 initialPosition; 


    [SerializeField]
    GameManager gameManager = null;

    [SerializeField]
    private float speed = 3.0f;
    private float gravity = 9.8f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        //gameObject.transform.position = initialPosition;
        setInitialPosition();
    }

    void OnEnable(){
        setInitialPosition();
        //gameObject.transform.position = initialPosition;
    }

    void Update()
    {
        
        CalculateMove();
    }



    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Enemy")){
            gameManager.GameOver();
            gameObject.SetActive(false);
        }    
    }



    void CalculateMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = direction * speed;
        velocity.y -= gravity;
        velocity = transform.transform.TransformDirection(velocity);
        controller.Move(velocity * Time.deltaTime);
    }

    public void setInitialPosition(){
        gameObject.transform.position = initialPosition;
    }
}
