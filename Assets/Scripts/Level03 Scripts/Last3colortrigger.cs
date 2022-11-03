using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Last3colortrigger : MonoBehaviour
{
    [SerializeField]
    GameObject box, blackBox;

    int lockerCount = 0;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == box && lockerCount == 0)
        {
            Level03_Controller.Lcounter++;
            lockerCount++;
        }

        if(other.gameObject == blackBox)
        {
            Debug.Log("gateOpen");
            Level03_Controller.otherAnimator.SetBool("DoorOpen", true);
        }

    }
}
