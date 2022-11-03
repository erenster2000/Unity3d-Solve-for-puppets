using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTriggerYellowforOrange : MonoBehaviour
{
   [SerializeField]
    GameObject boxNeeded1, boxNeeded2;

    public static bool yellow = false;
    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject == boxNeeded1 || other.gameObject == boxNeeded2)
        {
            yellow = true;
            Debug.Log("asdskjlgf");

        }
        
    }
}
