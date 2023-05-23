using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseNormal //no tiene nada que ver con unity
{
    int numero1, numero2;

    public ClaseNormal(int x, int y) //constructor: como se va a construir una instancia de esta clase, esta
    //                                        clase no puede ser creada si no se le pasan los parametros
    {
        numero1 = x;
        numero2 = y;
    }

    public ClaseNormal (float x, float y) //Sobrecarga de constructores
    {
        numero1 = (int)x;
        numero1 = (int)y;
    }

    public int SumarEnteros(int a, int b)
    {
        return a + b;
    }

    public float SumarFloat(float a, float b) 
    {
        return a + b;
    }

    public static float MultiplicarFloat(float a, float b)
    {
        return a * b;
    }
}
