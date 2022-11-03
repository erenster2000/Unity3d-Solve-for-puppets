using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_02 : MonoBehaviour
{
    [SerializeField]
    GameObject cage;
       void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "MovableObject")
        {
            cage.SetActive(false);
        }
        
    } 
}
