using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTriggerRedforPurple : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
