using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CrearCuboDesde0 : MonoBehaviour
{
    GameObject objToSpawn;
    Vector3[] vertices = {  new Vector3 (0, 0, 0), //0
                            new Vector3 (1, 0, 0), //1
                            new Vector3 (1, 1, 0), //2
                            new Vector3 (0, 1, 0), //3
                            new Vector3 (0, 1, 1), //4
                            new Vector3 (1, 1, 1), //5
                            new Vector3 (1, 0, 1), //6
                            new Vector3 (0, 0, 1), }; //7
    int[] triangulos = {0, 2, 1, //1
                        0, 3, 2,
                        2, 3, 4, //2
                        2, 4, 5,
                        1, 2, 5, //3
                        1, 5, 6,
                        0, 7, 4, //4
                        0, 4, 3,
                        5, 4, 7, //5
                        5, 7, 6,
                        0, 6, 7, //6
                        0, 1, 6};

    // Start is called before the first frame update
    void Start()
    {
        objToSpawn = new GameObject("Mi Primer Cubo"); //crea el objeto y le pone nombre
        objToSpawn.AddComponent<MeshFilter>(); //agrega el mesh filter
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh; //hace referencia al mesh filter que ya se agrego
        meshFilter.Clear(); //limpia la variable, pone todo en 0
        meshFilter.vertices = vertices; //asigna los vertices
        meshFilter.triangles = triangulos; //asigna las caras
        meshFilter.Optimize(); //optimizar para renerizar en unity
        meshFilter.RecalculateNormals(); //recalcula las normales (el punto hacia donde voltean las caras)
        objToSpawn.AddComponent<BoxCollider>(); //agrga el boxCollider
        var boxCollider = objToSpawn.GetComponent<BoxCollider>(); //hace referencia al BoxCollider que ya se agrego
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f); //poner el boxCollider en la posicion que queremos
        objToSpawn.AddComponent<MeshRenderer>(); //agrega el mesh renderer
        var meshRendererMAterial = objToSpawn.GetComponent<MeshRenderer>().material; //hace referencia al material del meshRenderer
        meshRendererMAterial.color = Color.white; //asignar color
        objToSpawn.transform.position = Vector3.one; //le da una posición al objeto
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
