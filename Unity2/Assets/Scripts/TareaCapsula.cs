using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCapsula : MonoBehaviour
{
    public GameObject capsula;
    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        capsula.GetComponent<MeshRenderer>().material.color = c; //colores aleatorios
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
