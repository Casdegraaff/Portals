using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balcon : MonoBehaviour
{
    public Transform PortalOutObj;
    
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Portal")
        {
            GetComponent<Transform>().position = PortalOutObj.position;
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.z,0,0);
        }
    }
}
