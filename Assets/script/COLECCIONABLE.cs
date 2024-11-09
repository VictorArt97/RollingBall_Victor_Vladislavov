using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLECCIONABLE : MonoBehaviour
{
    [SerializeField] Vector3 sentido;
    [SerializeField] float velodidadRotacion;
    [SerializeField] Vector3 direccion ;
 
    [SerializeField] float velocidad;
    float timer;
    void Start()
    {
        
    }
    
    void Update()
    {
        timer += 1 * Time.deltaTime;
        transform.Translate(direccion * velocidad * Time.deltaTime);
        transform.Rotate(sentido*velodidadRotacion*Time.deltaTime,Space.World); // , Space.World para que gire en torno al mundo
        if (timer >= 2)
        {
            timer = 0;
            direccion *= -1;
        }
    }
}
