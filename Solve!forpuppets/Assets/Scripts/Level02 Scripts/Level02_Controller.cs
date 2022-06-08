using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02_Controller : MonoBehaviour
{
    public static int Lcounter;
    private bool CounterBool = true;

    public GameObject Door;
    Animator otherAnimator;
    void Start()
    {
       otherAnimator = Door.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Lcounter == 3 && CounterBool == true)
        {
            otherAnimator.SetBool("DoorOpen", true);
            CounterBool = false;
        }
        
    }
}
