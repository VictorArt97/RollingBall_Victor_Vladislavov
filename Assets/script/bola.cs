using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    Vector3 direccion;
    [SerializeField] int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.W)) {
        moverse();

    }

    void moverse()
    {
        float h= Input.GetAxisRaw("Horizontal");  // A,D, <--, -->  , h=1 (D o -->) y h = -1 ( A o <--) , h=o ( nada )
        float v= Input.GetAxisRaw("Vertical");  // A,D, <--, -->  , v=1 (w o ^) y v = -1 ( s o v) , v=o ( nada )

        direccion.x =h;
        direccion.z =v;
        transform.Translate(direccion *velocidad*Time.deltaTime);

    }
}
