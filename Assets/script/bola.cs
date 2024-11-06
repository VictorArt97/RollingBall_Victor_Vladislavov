using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bola : MonoBehaviour
{
    // Movimiento de la bola 
    Vector3 direccion;
    [SerializeField] Vector3 direccionSalto;
    [SerializeField] int velocidad;
    [SerializeField] int fuerzaSalto;
    [SerializeField] int fuerzaVelocidad;
    private float h, v;
    Rigidbody rb;
    
    // puntuacion
    [SerializeField] int puntuacion;
    [SerializeField] TMP_Text textoPuntuacion;

    [SerializeField] float distanciaDeteccionSuelo;
    // Vida de la bola
    [SerializeField] float vida = 100f;

    [SerializeField] LayerMask queEsSuelo;


    [SerializeField] AudioClip coleccionable;
    [SerializeField] AudioManager manager;



    void Start()
    {
       rb= GetComponent<Rigidbody>();
    }

    void Update()     ///Ciclo variable 
    {
        // if (Input.GetKeyDown(KeyCode.W)) {
        Moverse();
    }

    void Moverse()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();

        h= Input.GetAxisRaw("Horizontal");  // A,D, <--, -->  , h=1 (D o -->) y h = -1 ( A o <--) , h=o ( nada )
        v= Input.GetAxisRaw("Vertical");  // A,D, <--, -->  , v=1 (w o ^) y v = -1 ( s o v) , v=o ( nada )
        direccion.x = h;
        direccion.z = v;


        if (Input.GetKeyDown(KeyCode.Space))    
        {
            if (DetectarSuelo() == true)
            {          
                rb.AddForce(direccionSalto*fuerzaSalto,ForceMode.Impulse);
            }
        }

       //rb.AddForce(direccion*fuerzaVelocidad,ForceMode.Force);

       // rb.velocity = direccion*Time.deltaTime;                     // este ta mal >:(
        //transform.Translate(direccion *velocidad*Time.deltaTime);

    }

    bool DetectarSuelo()
    {
       bool resultado = Physics.Raycast(transform.position, new Vector3 (0,-1,0),distanciaDeteccionSuelo,queEsSuelo);
        return resultado;
    }


    private void FixedUpdate()   /// FIJO / CONSTANTE se reproduce cada 0,02 segundos (Pensado para fisicas continuas)
    {
        
        rb.AddForce(new Vector3(h,0,v).normalized*fuerzaVelocidad, ForceMode.Force);
    }


    // se Produce automaticxamente cuando atravesamos un trigger 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Atravesado");
        if (other.gameObject.CompareTag("coleccionable"))
        {
            manager.ReproducirSonido(coleccionable);
            Destroy(other.gameObject);
            puntuacion += 10;
        } 
        
        if (other.gameObject.CompareTag("trampa"))
        {
            vida -= 10;
       
            if (vida <= 0)
     
            {            
                Destroy(this.gameObject);        
            }
        }
      
        textoPuntuacion.SetText("Score: "+puntuacion);
    }
}
