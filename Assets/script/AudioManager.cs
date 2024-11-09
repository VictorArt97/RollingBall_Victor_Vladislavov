using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sfx ;

    public void ReproducirSonido(AudioClip SonidoLOL)
    {
        // Reproduce el Clip Introducido en el parametro de entrada
        sfx.PlayOneShot(SonidoLOL);
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("colecionable"))
       {
            //sfx.PlayOneShot(SONIDO_MONEDA);
        }
    }
}
