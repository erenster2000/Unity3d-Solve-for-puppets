using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;

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

        transform.Translate(move * magnitude * Time.deltaTime, Space.World);

        if(move != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

    }
}
