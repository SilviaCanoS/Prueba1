using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaEsfera2 : MonoBehaviour
{
    public TareaCubo cubo;
    public TareaCubo2 cubo2;
    public TareaEsfera esfera;
    public bool esferaColor;
    public TareaCapsula capsula;
    public TareaCapsula2 capsula2;
    public GameObject esfera2;
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
        esferaColor = (cubo.colorCubo && cubo2.colorCubo2) || (capsula.colorCapsula && capsula2.colorCapsula2);
        switch (esferaColor)
        {
            case true when esfera.colorEsfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case false when esfera.colorEsfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case true when !esfera.colorEsfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case false when !esfera.colorEsfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            default:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }
    }
}
