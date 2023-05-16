using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea2Modulo6 : MonoBehaviour
{
    public GameObject prefabCubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "Mi Cuarto Cubo";
        tempGameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "Mi Quinto Cubo";
        tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
