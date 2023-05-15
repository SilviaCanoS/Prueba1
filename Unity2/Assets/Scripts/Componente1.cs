using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public static GameObject miObjeto; //publica y estatica para poder acceder a ella desde otros scripts

    private void Awake()
    {
        miObjeto = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
