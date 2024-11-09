using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_Control : MonoBehaviour
{
    [SerializeField] GameObject Object_pausa;

    public bool pausa = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Object_pausa.SetActive(true);
            pausa = true;
            Time.timeScale = 0;
        }

    }

    public void Reanudar()
    {
        Object_pausa.SetActive(false);
        pausa=false;
        Time.timeScale = 1;
    }

    public void Reiniciar ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
   
    public void SalirAInicio()
    {
        SceneManager.LoadScene(0);
    }
}
