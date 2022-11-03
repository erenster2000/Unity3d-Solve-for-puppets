using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTriggerRedforOrange : MonoBehaviour
{
   [SerializeField]
    GameObject boxNeeded1, boxNeeded2;

    public static bool red = false;
    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject == boxNeeded1 || other.gameObject == boxNeeded2)
        {
            red = true;
            Debug.Log("asdskjlgf");

        }
        
    }
}
