using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float gravitation = -9.0f;
    private PlayerStats playerStats;
    private CharacterController characterController;
    private Vector3 movement;
   
    private int lineToMove = 1;
    private float lineDistance = 2f;

    void Start()
    {
        movement = Vector3.zero;
        characterController = GetComponent<CharacterController>();
        playerStats = GetComponent<PlayerStats>();
    }
    void Update()
    {
        Dodge();
        Jump();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        movement.z = playerStats.GetRunningSpeed();
        movement.y += gravitation*Time.deltaTime;
        characterController.Move(movement * Time.deltaTime);
    }

    private void Dodge(){
        if (Input.GetButtonDown("Fire1") && lineToMove < 2)
        {
            lineToMove++;
        }
        if (Input.GetButtonDown("Fire2") && lineToMove > 0)
        {
            lineToMove--;
        }
        Vector3 targetPos = transform.position.z * transform.forward + transform.position.y * transform.up;
        if(lineToMove==0){
            targetPos += Vector3.right * lineDistance;
        }
        else if(lineToMove==2){
            targetPos += Vector3.left * lineDistance;
        }
        transform.position = targetPos;
    }

    private void Jump(){
        if (Input.GetButtonDown("Jump"))
        {
            movement.y = playerStats.GetJumpHeigth();
        }
    }
}



