using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaEsfera2 : MonoBehaviour
{
    public bool cubo, cubo2, esfera, esferaColor, capsula, capsula2;
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
        cubo = TareaCubo.colorCubo;
        cubo2 = TareaCubo2.colorCubo2;
        esfera = TareaEsfera.colorEsfera;
        capsula = TareaCapsula.colorCapsula;
        capsula2 = TareaCapsula2.colorCapsula2;

        esferaColor = (cubo && cubo2) || (capsula && capsula2);
        switch (esferaColor)
        {
            case true when esfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case false when esfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case true when !esfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case false when !esfera:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            default:
                esfera2.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }
    }
}
