using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntes_Vectores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (9,5,6);
        transform.eulerAngles = new Vector3 (90,45,0);
        transform.localScale = new Vector3 (90,45,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
