using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject prefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubo = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos= new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubo++;
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "CuboNumero" + numCubo;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c; //colores aleatorios
        tempGameObject.transform.position = Random.insideUnitSphere; //esfera es en espacio 3D

        //hace que los cubos se vuelvan más pequeños con cada frame y despues de cierto tamaño, se eliminen
        listaDeCubos.Add(tempGameObject);
        List<GameObject> objParaEliminar = new List<GameObject>();
        foreach(GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x; //solo en un eje porque es un cubo, todos sus lados son iguales
            scale *= factorDeEscalamiento; //scale = scale * factorDeEscalamiento
            go.transform.localScale = Vector3.one * scale; //da un nuevo tamaño al objeto

            if(scale <= 0.1) objParaEliminar.Add(go);
        }
        foreach(GameObject go in objParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go); //el factor de escalamiento va en unity
        }
    }
}
