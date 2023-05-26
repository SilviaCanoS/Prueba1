using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    //var no se puede poner aqui
    int[] arregloNumeros = new int[15];
    List<int> listaEnteros = new List<int>();
    List<string> listaString = new List<string>();
    HashSet<int> hashEnteros = new HashSet<int>(); //lista sin elementos repetidos y que no esta ordenada
    Queue<string> colaString = new Queue<string>(); //Fist In First Out
    Stack<string> pilaString = new Stack<string>(); //First In Last Out
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

    // Start is called before the first frame update
    void Start()
    {
        listaEnteros = CrearUnaLista(Random.Range(1, 10), Random.Range(0, 10), Random.Range(10, 20));
        foreach (var elemento in listaEnteros) Debug.Log(elemento);

        Debug.Log("Arreglo de enteros:");
        for (int i = 0; i <= arregloNumeros.Length - 1; i++)
        {
            arregloNumeros[i] = Random.Range(0, 100);
            Debug.Log(arregloNumeros[i]);
        }
        arregloNumeros = ArregloDescendente(arregloNumeros);
        foreach (var elemento in arregloNumeros) Debug.Log(elemento);

        listaEnteros.Add(listaEnteros[0]);
        Debug.Log("Lista:");
        foreach (var elemento in listaEnteros) Debug.Log(elemento);
        hashEnteros = DeListaAHashSet(listaEnteros);
        foreach (var elemento in hashEnteros) Debug.Log(elemento);

        pilaString.Push("México");
        pilaString.Push("Italia");
        pilaString.Push("Japon");
        pilaString.Push("Egipto");
        pilaString.Push("Australia");
        DePilaACola(pilaString);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<int> CrearUnaLista(int tamaño, int rangoMin, int rangoMax)
    {
        List<int> listaTemp = new List<int>();
        Debug.Log($"Se creará una lista de {tamaño} elementos, el menor podrá ser {rangoMin} y el mayor, {rangoMax}");
        for (int i = 0; i <= tamaño - 1; i++)
            listaTemp.Add(Random.Range(rangoMin, rangoMax + 1));
        return listaTemp;
    }

    public int[] ArregloDescendente(int[] arregloEnteros)
    {
        int[] arregloTemp = new int[arregloEnteros.Length];
        Debug.Log("Se ordenará el arreglo de manera descendente");
        arregloTemp = arregloEnteros.OrderByDescending(p => p).ToArray();
        return arregloTemp;
    }

    public HashSet<int> DeListaAHashSet(List<int> lista)
    {
        Debug.Log("Se transformará una lista en hashSet");
        HashSet<int>  hashTemp = new HashSet<int>(lista);
        return hashTemp;
    }

    public void DePilaACola(Stack<string> pilaPaises)
    {
        Queue<string> colaTemp = new Queue<string>();
        int tamaño = pilaPaises.Count;
        Debug.Log("El contenido de la pila:");
        while(colaTemp.Count != tamaño)
        {
            Debug.Log(pilaPaises.Peek());
            colaTemp.Enqueue(pilaPaises.Peek());
            pilaPaises.Pop();
        }
        Debug.Log("El contenido de la cola:");
        while(colaTemp.Count != 0)
        {
            Debug.Log(colaTemp.Peek());
            colaTemp.Dequeue();
        }

        //Para no eliminar ningun dato ni de la pila ni de la cola
        //foreach(string s in pilaPaises)
        //{
        //    Debug.Log(s);
        //    colaTemp.Enqueue(s);
        //}
        //foreach(string s in colaTemp) Debug.Log(s); 
    }

    public void DemoListas()
    {
        //agregar datos a las listas
        for (int i = 0; i <= 20; i++) listaEnteros.Add(Random.Range(0, 20));
        listaString.Add("Diego");
        listaString.Add("Sofia");
        listaString.Add("Daniel");
        listaString.Add("Javier");
        listaString.Add("Diana");

        //eliminar un elemento de la lista
        listaString.Remove("Javier");
        listaString.RemoveAt(0);

        listaEnteros.Sort(); //ordenar los elementos de la lista

        //linq, p es para tipos de datos mas complejos
        var listaOrdenada = listaEnteros.OrderBy(p => p).ToList(); //ordena, lo regresa enumerado
        var listaescendente = listaEnteros.OrderByDescending(p => p).ToList(); //ordena descendentemente
        var listaConValoresGrandes = listaEnteros.Where(p => p > 10).ToList(); //regresa solo los valores > 10
    }

    public void DemoHashSet() //Se usan por temas de optimizacion, son más rápidos que las listas
    {
        for (int i = 0; i <= 20; i++) hashEnteros.Add(i); //agregar datos al hashSet

        if (hashEnteros.Contains(5)) hashEnteros.Remove(5); //buscar un elemento y eliminarlo del hashSet
    }

    public void DemoQueue() //se suele usar en el envio y recepcion de mensajes
    {
        //agregar datos a la cola
        colaString.Enqueue("Proyectil 1");
        colaString.Enqueue("Proyectil 2");
        colaString.Enqueue("Proyectil 3");
        colaString.Enqueue("Proyectil 4");
        colaString.Enqueue("Proyectil 5");

        Debug.Log(colaString.Peek()); //imprime el primer elemento de la cola 

        colaString.Dequeue(); //eliminar un elemento de la cola
    }

    public void DemoStack()
    {
        pilaString.Push("As");
        pilaString.Push("5Espadas");
        pilaString.Push("3Corazones");
        pilaString.Push("4Trebol");
        pilaString.Push("ReyEspadas");

        Debug.Log(colaString.Peek()); //imprime el ultimo elemento de la pila 

        pilaString.Pop(); //eliminar un elemento de la pila 
    }

    public void DemoDiccionario(string arma) //(llave, valor) el valor puede no existir pero la llave es necesaria
    {
        float temporal = 0;

        //Verifica si existe la llave y si no, la agrega
        if (!poderArmas.ContainsKey("Rifle"))               poderArmas.Add("Rifle", 7);
        if (!poderArmas.ContainsKey("Pistola"))             poderArmas.Add("Pistola", 3);
        if (!poderArmas.ContainsKey("Escopeta"))            poderArmas.Add("Escopeta", 5);
        if (!poderArmas.ContainsKey("RifleFrancotirador"))  poderArmas.Add("RifleFrancotirador", 10);
        if (!poderArmas.ContainsKey("Cuchillo"))            poderArmas.Add("Cuchillo", 2);
        poderArmas.TryAdd("Katana", 5);

        //Verifica si existe y luego lo imprime
        if (poderArmas.TryGetValue(arma, out temporal)) Debug.Log(temporal);
    }
}
