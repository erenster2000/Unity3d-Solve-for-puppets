using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject solve1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ae());
    }

    IEnumerator ae()
    {
        yield return new WaitForSeconds(5);
        solve1.gameObject.SetActive(false);

    }
}
