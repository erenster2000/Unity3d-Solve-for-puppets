using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnder : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "MovableObject")
        {
            SceneManager.LoadScene("Level_02");
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
