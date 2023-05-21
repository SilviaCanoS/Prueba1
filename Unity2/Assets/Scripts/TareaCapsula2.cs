using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCapsula2 : MonoBehaviour
{
    public GameObject capsula2;
    public bool colorCapsula2;
    public TareaEsfera esfera;
    public TareaCubo cubo;

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
        if (cubo.colorCubo || esfera.colorEsfera)
        {
            capsula2.GetComponent<MeshRenderer>().material.color = Color.white;
            colorCapsula2 = true;
        }
        else
        {
            capsula2.GetComponent<MeshRenderer>().material.color = Color.black;
            colorCapsula2 = false;
        }
    }
}
