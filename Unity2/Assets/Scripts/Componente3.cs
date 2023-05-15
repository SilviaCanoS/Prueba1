using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Componente1.miObjeto.name = "NuevoNombreDeMiObjeto";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
