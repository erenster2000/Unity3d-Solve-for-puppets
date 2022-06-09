using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public static bool gemCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 , 20 * Time.deltaTime, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Player"))
        {
        gemCollected = true;
        gameObject.SetActive(false);
        }
        
    }
}
