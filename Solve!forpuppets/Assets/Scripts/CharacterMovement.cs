using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private Animator animator;

    private CharacterController characterController;

    private bool freezeRot = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalMove, 0, verticalMove);
        float magnitude = Mathf.Clamp01(move.magnitude) * speed;
        move.Normalize();

        characterController.SimpleMove(move * magnitude);

        if(move != Vector3.zero)
        {
            animator.SetBool("isMoving", true);
            if(!freezeRot)
            {
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if(hit.gameObject.tag == "MovableObject")
        {
            animator.SetBool("pushing", true);
            freezeRot = true;
            //hit.transform.parent = transform;
        }


    }

    void OnTriggerEnter(Collider other)
     {
         if(other.gameObject.tag == "box")
        {
            animator.SetBool("pushing", false);
            freezeRot = false;
        }

     }


    
}
