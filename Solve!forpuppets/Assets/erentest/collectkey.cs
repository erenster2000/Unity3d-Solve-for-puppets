using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectkey : MonoBehaviour
{
   public void OnTriggerEnter(Collider other)
    {
        scoresystem.theScore += 50;
        Destroy(gameObject);
    }
}
