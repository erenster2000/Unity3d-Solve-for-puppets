using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageController : MonoBehaviour
{
    public float RotationSpeed = 25;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 , RotationSpeed * Time.deltaTime, 0);
    }
}
