using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTriggerYellowforGreen : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
