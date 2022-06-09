using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOpenController : MonoBehaviour
{
    [SerializeField]
    GameObject placedGem, Bridge;

    Animator otherAnimator;
    void Start()
    {
        otherAnimator = Bridge.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"  && GemCollect.gemCollected == true)
        {        
            placedGem.SetActive(true); 
            otherAnimator.SetBool("BridgeOpen", true);       
        }
        
    }
}
