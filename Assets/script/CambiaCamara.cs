using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamara : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject camCenital;

    public void Start()
    {
        camCenital .SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (cam1.activeSelf)
            {           
                cam1.SetActive(false);           
                camCenital.SetActive(true);
            } 
            
            else
            {           
                cam1.SetActive(true);           
                camCenital.SetActive(false);
            }
        }
    }
}
