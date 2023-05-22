using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    string s = "";
    int i, j, suma, cont = 0, cont2 = 0;
    int[] arregloA = new int[5], arregloB = new int[5], arregloC = new int[5], 
          arregloEnteros = new int[] {10, 11, 12};
    string[] arregloString = new string[] {"When", "people", "run", "in", "circles", "it's", "a", "very", 
                                            "mad", "world"};
    int[,] matrizEnteros = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    string[,] matrizString = new string[3, 3] { {"Silvia", "Luna", "Abel"}, {"Coco", "Holly", "Ronda"},
                                                {"Bailey", "Jengibre", "Oreo"} };
    //int[][] jaggedEnteros = new int[3][] { new int[] {1, 2, 3},
    //                                       new int[] {4, 5},
    //                                       new int[] {6, 7, 8, 9} };

    // Start is called before the first frame update
    void Start()
    {
        //arregloEnteros = new int[7]; //cambia la capacidad del arreglo pero se resetea
        //jaggedEnteros[1] = new int[] { 10, 11, 12, 13, 14 }; //modifica el renglon 1

        while(cont <= matrizEnteros.GetLength(0) - 1)
        {
            while(cont2 <= matrizEnteros.GetLength(1) -1)
            {
                Debug.Log(matrizEnteros[cont,cont2]);
                cont2++;
            }
            cont2 = 0;
            cont++;
        }

        cont = 0;
        cont2 = 0;
        do
        {
            do
            {
                Debug.Log(matrizString[cont, cont2]);
                cont2++;
            } while (cont2 <= matrizEnteros.GetLength(1) - 1);
            cont2 = 0;
            cont++;
        } while (cont <= matrizString.GetLength(0) - 1);

        for (i = 0; i <= arregloC.Length - 1; i++)
        {
            arregloA[i] = Random.Range(0, 99);
            arregloB[i] = Random.Range(0, 99);
            arregloC[i] = arregloA[i] + arregloB[i];
            Debug.Log(arregloA[i] + " + " + arregloB[i] + " = " + arregloC[i]);
        }

        foreach (string x in arregloString) //no se puede modificar el contador
        {
            s += x + " ";
            if (x == "very") s += x + " ";
        }
        Debug.Log(s);

        int[] arregloResultado = new int[matrizEnteros.GetLength(0)];
        for (i = 0; i <= matrizEnteros.GetLength(0) - 1; i++)
        {
            for (j = 0; j <= matrizEnteros.GetLength(1) - 1; j++)
                matrizEnteros[i, j] = matrizEnteros[i, j] * arregloEnteros[j];
        }
        for (i = 0; i <= matrizEnteros.GetLength(0) - 1; i++)
        {
            suma = 0;
            for (j = 0; j <= matrizEnteros.GetLength(1) - 1; j++)
                suma += matrizEnteros[i, j];
            arregloResultado[i] = suma;
            Debug.Log(arregloResultado[i]);
        }

        //for (int l = 0; l <= jaggedEnteros.Length - 1; l++)
        //{
        //    for (int m = 0; m <= jaggedEnteros[1].Length - 1; m++) Debug.Log(jaggedEnteros[l][m]);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
