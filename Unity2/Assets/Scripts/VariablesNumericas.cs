using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    //Byte  [0 0 0 0 0 0 0 0] -> 8bits, el primer bit representa el signo (1=-)
    //Short [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Int   [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Long  [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //De long a int se eliminan los 4 primeros bytes

    //Float  [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Double [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Decimal es más preciso

    //sbyte miByteConSigno = 0;
    //byte miByte = 0;
    //short miShort = 0;
    //ushort miShortConSigno = 0;
    //uint miIntConSigno = 0;
    //long miLong = long.MaxValue; //guarda el numero mas grande posible
    //ulong miLongConSigno = 0;
    int miInt = 0;
    float miFloat = 1;
    public GameObject cubo;


    // Start is called before the first frame update
    void Start()
    {
        float a = 1.5f, b = 3.5f;
        int c = (int) (a+b);
        Debug.Log("Int convertido a Float con casteo explicito: " + c);
    }

    // Update is called once per frame
    void Update()
    {
        miInt += 3;
        if (miInt % 2 == 0)
        {
            Debug.Log($"{miInt} Es par");
            cubo.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            Debug.Log($"{miInt} Es impar");
            cubo.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    private void FixedUpdate()
    {
        miFloat *= 1.5f;
        Debug.Log(miFloat);
    }
}
