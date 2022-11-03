using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterTeleportController : MonoBehaviour
{
    [SerializeField]
    public GameObject portal01;
    public GameObject otherObject;
    Animator otherAnimator;
    // Start is called before the first frame update

    void Start()
    {
        otherAnimator = otherObject.GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Portal01")
        {
            transform.position = new Vector3(-4, 6, 1);
            otherAnimator.SetBool("pushing", false);
            CharacterMovement.freezeRot = false;

        }
        
    }


}
