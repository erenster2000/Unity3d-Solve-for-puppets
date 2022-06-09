using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level02_Controller : MonoBehaviour
{
    public static int Lcounter;
    private bool CounterBool = true;

    public GameObject Door, solve2;
    Animator otherAnimator;
    
    
    void Start()
    {
       otherAnimator = Door.GetComponent<Animator>(); 
       StartCoroutine(aea());
    }

    IEnumerator aea()
    {
        yield return new WaitForSeconds(5);
        solve2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Lcounter == 3 && CounterBool == true)
        {
            otherAnimator.SetBool("DoorOpen", true);
            CounterBool = false;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Lcounter = 0;
            SceneManager.LoadScene(2);
        }
        
    }
public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Player"))
        {
        SceneManager.LoadScene(3);
        }

    }

}
