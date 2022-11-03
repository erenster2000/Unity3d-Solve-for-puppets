using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTriggerBlueforPurple : MonoBehaviour
{
    [SerializeField]
    GameObject boxNeeded1, boxNeeded2;

    public static bool blue = false;
    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject == boxNeeded1 || other.gameObject == boxNeeded2)
        {
            blue = true;
            Debug.Log("asdskjlgf");

        }
        
    }
}
