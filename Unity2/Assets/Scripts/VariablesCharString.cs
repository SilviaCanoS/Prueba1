using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharString : MonoBehaviour
{
    //char c = '9';
    //int i;
    public string s = "Hola Mundo", pi, miNombre = "Silvia Elisa Cano Sarabia";
    public List<string> l = new List<string>() {"rojo", "azul", "verde", "amarillo", "gris", "negro", "blanco",
                                        "magenta", "cian"};
    public GameObject esfera;

    // Start is called before the first frame update
    void Start()
    {
        //de char a int
        //i = (int)char.GetNumericValue(c);
        //i = c - '0'; 
        //i = int.Parse(c.ToString()); 
        //bool b = int.TryParse(c.ToString(), out i); //comprueba si es un valor numerico

        //c = s[3]; //toma un caracter de la cadena
        //i = s.Length; //cuenta los caracteres de la cadena, empieza en 1
        //s = s.Replace('o', 'x'); //reemplaza todos los caracteres iguales por otro
        //s = s.ToUpper(); //hace todo mayusculas, toLower hace todo minusculas
        //s = s + " desde aquí"; //concatenacion
        //s = s.Substring(0, 10); //Toma una parte de la cadena

        pi = Mathf.PI.ToString();
        Debug.Log($"Pi es igual a {pi.Substring(0, 6)}");

        string nombres = miNombre.Substring(0, 12);
        string apellidoPaterno = miNombre.Substring(13, 4);
        string apellidoMaterno = miNombre.Substring(18, 7);
        Debug.Log($"Mi nombre es {nombres} {apellidoPaterno} {apellidoMaterno}");

        string[] nombreSeparado = miNombre.Split(' ');
        for(int x = 0; x <= nombreSeparado.Length-1; x++)
            Debug.Log(nombreSeparado[x]);
    }

    // Update is called once per frame
    void Update()
    {
        s = l[Random.Range(0, 9)];
        switch(s)
        {
            case "rojo":
                esfera.GetComponent<MeshRenderer>().material.color = Color.red; break;
            case "azul":
                esfera.GetComponent<MeshRenderer>().material.color = Color.blue; break;
            case "verde":
                esfera.GetComponent<MeshRenderer>().material.color = Color.green; break;
            case "amarillo":
                esfera.GetComponent<MeshRenderer>().material.color = Color.yellow; break;
            case "gris":
                esfera.GetComponent<MeshRenderer>().material.color = Color.gray; break;
            case "negro":
                esfera.GetComponent<MeshRenderer>().material.color = Color.black; break;
            case "blanco":
                esfera.GetComponent<MeshRenderer>().material.color = Color.white; break;
            case "megenta":
                esfera.GetComponent<MeshRenderer>().material.color = Color.magenta; break;
            case "cian":
                esfera.GetComponent<MeshRenderer>().material.color = Color.cyan; break;
            default:
                Debug.Log("Color invalido"); break;
        }
    }
}
