using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
    public DatosCiudd utilCiudd;

    public Vector3 ubic;
    void Awake()
    {
        utilCiudd.edadCiudd = Random.Range(15, 101);
        int darNomb = Random.Range(0, 21);
        utilCiudd.varNombrs =(DatosCiudd.nombreCiudd)darNomb;
        ubic = new Vector3(Random.Range(1, 20), 0.5f, Random.Range(1, 20));
    }

    
    void Update()
    {
        
    }
}

public struct DatosCiudd
{
    public enum nombreCiudd
    {
        rolando, josue, jaimito, romualdo, dioselina, maripan, consepcion, pancracia, leocadio, anzisar, juvenal, arturito, casilda, zacarin, antanas, gargamel, marucha, enriqueta, sinthia, anastasia
    }
    public nombreCiudd varNombrs;

    public int edadCiudd;
}
