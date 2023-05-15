using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    private void Awake()
    {
        Debug.Log("Hola Mundo desde Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        //print("Algo pasó"); //informativo, requiere la palabra MonoBehaviour despues de la clase
        Debug.Log("Hola Mundo desde Start"); //informativo
        //Debug.LogError("Algo salio muy mal"); //Error
        //Debug.LogWarning("Algo puede salir mal"); //Advertencia
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        //Debug.Log(x);

        Debug.LogWarning("Hola Mundo desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogError("Hola Mundo desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola Mundo desde Late Update");
    }

    private void OnEnable()
    {
        //Debug.Log("El objeto ha sido habilitado");
        Debug.Log("Hola Mundo desde OnEnable");
    }

    private void OnDisable()
    {
        //Debug.Log("El objeto ha sido inhabilitado");
        Debug.Log("Hola Mundo desde OnDisable");
    }
}
