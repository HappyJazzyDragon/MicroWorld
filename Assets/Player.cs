using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("RequiredChildReferences")]
    public Transform torso;
    public Transform head;

    [Header("RequiredPrefabReferences")]
    public GameObject projectile;

    [Header("TweakValues")]
    public float rotationSpeed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        torso.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime);
        head.Rotate(Vector3.right, Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectile, head.position, head.rotation);
        }
    }
}
