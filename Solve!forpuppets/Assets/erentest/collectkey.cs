using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectkey : MonoBehaviour
{
    private float RotationSpeed = 20;
    void Update()
    {
        transform.Rotate(0 , RotationSpeed * Time.deltaTime, 0);
    }
   public void OnTriggerEnter(Collider other)
    {
        scoresystem.theScore += 50;
        gameObject.SetActive(false);
    }
}
