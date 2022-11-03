using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_01 : MonoBehaviour
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
