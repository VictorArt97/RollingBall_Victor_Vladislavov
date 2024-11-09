using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroCubos : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rbs;
    [SerializeField] private float tiempoBola;

    private float timer = 0f;
    private bool iniciarCuenta = false;
    
    void Start()
    {
        if (iniciarCuenta)
        {
            timer += 1 * Time.deltaTime;
            if (timer >= 2f)
            {
                Time.timeScale = 1f;
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].useGravity = true;
                }
            }
        }      
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.5f;
        }
    }
}
