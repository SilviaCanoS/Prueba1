using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCubo2 : MonoBehaviour
{
    public GameObject cubo2;
    public bool colorCubo2;
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
        cubo2.GetComponent<MeshRenderer>().material.color = cubo.colorCubo ? Color.white : Color.black;
        colorCubo2 = cubo.colorCubo;
    }
}
