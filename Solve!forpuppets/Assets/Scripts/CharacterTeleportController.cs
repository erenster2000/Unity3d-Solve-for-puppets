using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTeleportController : MonoBehaviour
{
    [SerializeField]
    public GameObject portal01;
    private Animator animator;
    // Start is called before the first frame update

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Portal01")
        {
            transform.position = new Vector3(-4, 6, 1);
            animator.SetBool("pushing", false);

        }
        
    }


}
