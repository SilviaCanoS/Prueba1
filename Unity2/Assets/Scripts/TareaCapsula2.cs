using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCapsula2 : MonoBehaviour
{
    public GameObject capsula2;
    public bool esfera, cubo;
    public static bool colorCapsula2;

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
        colorCapsula2 = !colorCapsula2;
        esfera = TareaEsfera.colorEsfera;
        cubo = TareaCubo.colorCubo;
        if (cubo || esfera)
            capsula2.GetComponent<MeshRenderer>().material.color = Color.white;
        else
            capsula2.GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
