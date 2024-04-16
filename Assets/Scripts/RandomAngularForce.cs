using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAngularForce : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float minForceAmount = 50.0f;
    public float maxForceAmount = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.AddTorque(Random.onUnitSphere * Random.Range(minForceAmount,maxForceAmount));
    }
}
