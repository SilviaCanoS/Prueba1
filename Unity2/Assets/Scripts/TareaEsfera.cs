using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaEsfera : MonoBehaviour
{
    public GameObject esfera;
    public bool colorEsfera = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        esfera.GetComponent<MeshRenderer>().material.color = c; //colores aleatorios
    }
}
