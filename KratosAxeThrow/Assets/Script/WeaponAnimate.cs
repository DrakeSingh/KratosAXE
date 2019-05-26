using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimate : MonoBehaviour
{
    public bool activated;
    public float rotationSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            transform.localEulerAngles += Vector3.forward * rotationSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        activated = false;
    }
}
