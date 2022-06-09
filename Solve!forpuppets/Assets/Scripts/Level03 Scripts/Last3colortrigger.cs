using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Last3colortrigger : MonoBehaviour
{
    [SerializeField]
    GameObject box, blackBox;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == box)
        {
            Level03_Controller.Lcounter++;
        }

        if(other.gameObject == blackBox)
        {
            Debug.Log("gateOpen");
            Level03_Controller.otherAnimator.SetBool("DoorOpen", true);
        }

    }
}
