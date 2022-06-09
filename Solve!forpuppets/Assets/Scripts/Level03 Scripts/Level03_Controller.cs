using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level03_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject orangeB, purpleB, greenB, BlackB, Door, solve3;

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
            orangeB.gameObject.SetActive(false);

        }

        if(PlateTriggerBlueforPurple.blue == true && PlateTriggerRedforPurple.red == true)
        {
            purpleB.gameObject.SetActive(false);;

        }

        if(PlateTriggerBlueforGreen.blue == true && PlateTriggerYellowforGreen.yellow == true)
        {
            greenB.gameObject.SetActive(false);

        }

        if(Lcounter == 3)
        {
            //Debug.Log("BlackBox");
            BlackB.gameObject.SetActive(false);
            otherAnimator.SetBool("DoorOpen", true);
        }
    }
}
