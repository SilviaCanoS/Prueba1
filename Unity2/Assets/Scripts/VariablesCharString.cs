using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharString : MonoBehaviour
{
    //char c = '9';
    int i, i2;
    bool b, b2;
    public string s = "Hola Mundo", s2, pi, miNombre = "Silvia Elisa Cano Sarabia";
    public List<string> l = new List<string>() {"rojo", "azul", "verde", "amarillo", "gris", "negro", 
                                                "blanco", "magenta", "cian"};
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

        pi = Mathf.PI.ToString("N4");
        Debug.Log($"Pi es igual a {pi}");

        string nombres = miNombre.Substring(0, 12);
        string apellidoPaterno = miNombre.Substring(13, 4);
        string apellidoMaterno = miNombre.Substring(18, 7);
        Debug.Log($"Mi nombre es {nombres} {apellidoPaterno} {apellidoMaterno}");

        string[] nombreSeparado = miNombre.Split(' ');
        for(int x = 0; x <= nombreSeparado.Length-1; x++)
            Debug.Log(nombreSeparado[x]);

        s = Random.Range(1000, 9999).ToString();
        s2 = Random.Range(1000, 9999).ToString();
        b = int.TryParse(s, out i);
        b2 = int.TryParse(s2, out i2);
        if(b && b2) Debug.Log($"{s} + {s2} = {i + i2}");

        s = "Amo el canto del zenzontle, pájaro de cuatrocientas voces";
        s2 = "";
        for(i = 0; i <= s.Length - 1; i++)
        {
            if(i%2 == 0) s2 += s[i] + ", ";
        }
        Debug.Log(s2.Trim().Substring(0, s2.Length - 2));

        s = "Amo el color del jade y el enervante perfume de las flores";
        Debug.Log(s.Substring(5));
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
