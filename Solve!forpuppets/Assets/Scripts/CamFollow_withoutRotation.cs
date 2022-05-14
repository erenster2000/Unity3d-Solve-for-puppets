using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow_withoutRotation : MonoBehaviour
{
    public GameObject player;
    public float cameraHeight;
    public float cameraHeight_2;

    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.z += cameraHeight;
        pos.y += cameraHeight_2;
        transform.position = pos;
    }
}
