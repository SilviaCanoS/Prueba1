using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCubo2 : MonoBehaviour
{
    public GameObject cubo2;
    public bool cubo;
    public static bool colorCubo2;

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
        colorCubo2 = !colorCubo2;
        cubo = TareaCubo.colorCubo;
        cubo2.GetComponent<MeshRenderer>().material.color = cubo ? Color.black : Color.white;
        cubo = !cubo;
    }
}
