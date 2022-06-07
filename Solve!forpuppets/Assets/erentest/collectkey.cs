using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectkey : MonoBehaviour
{
    private float RotationSpeed = 20;

    public GameObject Door;
    Animator otherAnimator;

    void Start()
    {
        otherAnimator = Door.GetComponent<Animator>();
    }
    void Update()
    {
        transform.Rotate(0 , RotationSpeed * Time.deltaTime, 0);
    }
   public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Player"))
        {
        scoresystem.theScore += 1;
        gameObject.SetActive(false);
        if(scoresystem.theScore == 2)
        {
        otherAnimator.SetBool("DoorOpen", true);
        }
        }

    }
}
