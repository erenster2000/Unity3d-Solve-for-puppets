using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTeleporter : MonoBehaviour
{
    Animator otherAnimator;

    public GameObject otherObject;
    void Start()
    {
        otherAnimator = otherObject.GetComponent<Animator>();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Portal01")
        {
            transform.position = new Vector3(-7.60f, 4.5f, -15.85f);
            otherAnimator.SetBool("pushing", false);
            CharacterMovement.freezeRot = false;

        }
        if(other.gameObject.tag == "Portal02")
        {
            transform.position = new Vector3(-5.5f, 4.5f, -13.93f);
            otherAnimator.SetBool("pushing", false);
            CharacterMovement.freezeRot = false;

        }
        if(other.gameObject.tag == "Portal03")
        {
            transform.position = new Vector3(-3, 4.5f, -12.29f);
            otherAnimator.SetBool("pushing", false);
            CharacterMovement.freezeRot = false;

        }              
    }
}
