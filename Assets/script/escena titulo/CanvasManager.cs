using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    
    public void EmpezarPartid()
    {
        SceneManager.LoadScene(1);
    }
    public void TerminarJuego()
    {
        Application.Quit();
    }


}
