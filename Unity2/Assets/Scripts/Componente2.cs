using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    private void Awake() 
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Componente1.miObjeto.name); //llama al objeto de otra funcion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
