using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCubo : MonoBehaviour
{
    public GameObject cubo;
    public static bool colorCubo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Color c = new Color(Random.value, Random.value, Random.value);
        //cubo.GetComponent<MeshRenderer>().material.color = c; //colores aleatorios
    }

    private void FixedUpdate()
    {
        if (colorCubo == true)
        {
            cubo.GetComponent<MeshRenderer>().material.color = Color.white;
            colorCubo = false;
        }
        else
        {
            cubo.GetComponent<MeshRenderer>().material.color = Color.black;
            colorCubo = true;
        }
    }
}
