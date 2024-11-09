using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodilloGolpeador : MonoBehaviour
{
    
    [SerializeField] Vector3 direccion;
    [SerializeField] float fuerza;  
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccion*fuerza, ForceMode.VelocityChange);
    }

    void Update()
    {
      
        

    }
}
