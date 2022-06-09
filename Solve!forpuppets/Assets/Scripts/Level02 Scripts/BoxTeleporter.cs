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
            transform.position = new Vector3(-7.65f, 4.5f, -15.90f);
            otherAnimator.SetBool("pushing", false);
            CharacterMovement.freezeRot = false;

        }
        if(other.gameObject.tag == "Portal02")
        {
            transform.position = new Vector3(-5.55f, 4.5f, -13.98f);
            otherAnimator.SetBool("pushing", false);
            CharacterMovement.freezeRot = false;

        }
        if(other.gameObject.tag == "Portal03")
        {
            transform.position = new Vector3(-3.5f, 4.5f, -12.34f);
            otherAnimator.SetBool("pushing", false);
            CharacterMovement.freezeRot = false;

        }              
    }
}
