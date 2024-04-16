using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour
{
    public GameObject[] gibs;

    void OnTriggerEnter()
    {
        Instantiate(gibs[Random.Range(0, gibs.Length)], transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
