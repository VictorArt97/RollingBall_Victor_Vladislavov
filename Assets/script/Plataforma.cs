using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] Vector3 direccion ;
 
    [SerializeField] int velocidad;
    float timer;



    void Start()
    {
        
    }

    void Update()
    {
        timer += 1 * Time.deltaTime;
       

        transform.Translate(direccion * velocidad * Time.deltaTime);
        if (timer >= 2)
        {

            timer = 0;
            direccion *= -1;
        }
    }
}
