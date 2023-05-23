using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//poner 3 diagonales genera comentarios para documentacion xml autogenerada de c#

public class Clases : MonoBehaviour 
{
    //Campos de la clase: variables public (cualquier clase en el codigo puede verla), private (solo esta
    //                  clase tiene acceso) o protected (solo las clases hijo y esta podran verlo)
    //Por defecto todo se inicializa como privado 
    float campo1, campo3 = 5, campo4 = 4;
    bool campo2;

    //Funciones de Unity
    // Start is called before the first frame update
    void Start()
    {
        campo1 = sumaFloat(campo3, campo4);
        Debug.Log(campo1);
        vuelve0ElNumero(out campo1);
        Debug.Log(campo1);

        ClaseNormal miClase = new ClaseNormal(campo3, campo4); //instancia/ objeto de la clase
        campo1 = miClase.SumarFloat(campo3, campo4);
        Debug.Log(campo1);

        campo1 = ClaseNormal.MultiplicarFloat(campo3, campo4); //con la funcion static
        Debug.Log(campo1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //Funciones propias
    public float sumaFloat(float a, float b) //firma de la función
    {
        return a + b;
    }
    public void vuelve0ElNumero(out float numero) //out significa que la cariable sera modificada sin return (para operaciones sincronas)
    {
        numero = 0;
    }

    //propiedades: tiene metodos accesores (get: lee el valor de la variable, set: escribe en la variable)
    //es diferente a los campos porque te permite decidir que datos aceptar y que no
    public int propiedad1 { get; set; }
    public bool propiedad2 { get; set; }
    public float propiedadSoloLectura { get; }

    //tener los campos privados y la propiedades publicas para conseguir el encapsulamiento
}
