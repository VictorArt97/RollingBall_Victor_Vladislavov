using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodilloGolpeador : MonoBehaviour
{
    
    [SerializeField] Vector3 direccion;
    [SerializeField] int fuerza;

    [SerializeField] float velocidad;
    float timer;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccion*fuerza, ForceMode.VelocityChange);
    }

    void Update()
    {
        //timer += 1 * Time.deltaTime;
        //transform.Translate(direccion * velocidad * Time.deltaTime);
        //transform.Rotate(sentido * velodidadRotacion * Time.deltaTime, Space.World); // , Space.World para que gire en torno al mundo
        //if (timer >= 2)
        //{
        //    timer = 0;
        //    direccion *= -1;
        //}
        

    }
}
