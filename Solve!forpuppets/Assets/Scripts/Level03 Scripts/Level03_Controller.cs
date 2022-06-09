using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level03_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject orangeB, purpleB, greenB, Door, solve3;

    public static int Lcounter = 0;

    public static Animator otherAnimator;
    public void Start()
    {
        StartCoroutine(level3());
        otherAnimator = Door.GetComponent<Animator>(); 
    }

        IEnumerator level3()
    {
        yield return new WaitForSeconds(5);
        solve3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if(PlateTriggerYellowforOrange.yellow == true && PlateTriggerRedforOrange.red == true)
        {
            Debug.Log("sdaf");

        }

        if(PlateTriggerBlueforPurple.blue == true && PlateTriggerRedforPurple.red == true)
        {
            Debug.Log("sdaf");

        }

        if(PlateTriggerBlueforGreen.blue == true && PlateTriggerYellowforGreen.yellow == true)
        {
            Debug.Log("sdaf");

        }

        if(Lcounter == 3)
        {
            Debug.Log("BlackBox");
            otherAnimator.SetBool("DoorOpen", true);
        }
    }
}
