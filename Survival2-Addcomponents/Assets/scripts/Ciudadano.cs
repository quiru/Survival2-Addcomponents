using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
    public DatosCiudd utilCiudd; //variable de tipo estructura para utilizar datos

    public Vector3 ubic; // variable vector para dar la ubicacion
    void Awake()
    {
        utilCiudd.edadCiudd = Random.Range(15, 101); //da edad al ciudadano
        int darNomb = Random.Range(0, 21); //entero para asignar nombres
        utilCiudd.varNombrs =(DatosCiudd.nombreCiudd)darNomb; //da nombre al ciudadano
        ubic = new Vector3(Random.Range(1, 20), 0.5f, Random.Range(1, 20)); //vector para ubicar al ciudadano
    }
    
}

public struct DatosCiudd //estructura para guardar los datos del ciudadano
{
    public enum nombreCiudd //enum para guardar los nombre del ciudadano
    {
        rolando, josue, jaimito, romualdo, dioselina, maripan, consepcion, pancracia, leocadio, anzisar, juvenal, arturito, casilda, zacarin, antanas, gargamel, marucha, enriqueta, sinthia, anastasia
    }
    public nombreCiudd varNombrs; //variable de tipo enum para asignar nombres

    public int edadCiudd;
}
