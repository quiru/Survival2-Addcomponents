using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    GameObject heroe;  //variables para crear personajes
    GameObject zombi;
    GameObject ciudadano;
    DatosZombi utilZombi;
    
    void Start()
    {
        heroe = GameObject.CreatePrimitive(PrimitiveType.Cube); //crea personajes
        heroe.AddComponent<PersPersonal>(); //añade componentes
        heroe.AddComponent<MovFps>();
        heroe.AddComponent<Rigidbody>();
        GameObject movCam = new GameObject(); //crea un objeto para añadirle la camara y añadir este al heroe
        movCam.AddComponent<Camera>();
        movCam.AddComponent<CamFps>();
        movCam.transform.SetParent(heroe.transform);
        heroe.transform.position = new Vector3(Random.Range(1, 21), 0.5f, Random.Range(1, 21));

        int numZomb = Random.Range(9, 15); //random para creacion de zombies
        for (int i = 0; i < numZomb; i++) //for para crear zombis
        {
            
            zombi = GameObject.CreatePrimitive(PrimitiveType.Cube);
            zombi.AddComponent<Zombii>();
            zombi.transform.position = zombi.GetComponent<Zombii>().mov;
            utilZombi = zombi.GetComponent<Zombii>().utilZombii;
            zombi.GetComponent<Renderer>().material.color = utilZombi.colorZombi;
            zombi.AddComponent<Rigidbody>();
            zombi.name = "Zombi";
        }

        int numCiudd = Random.Range(5, 20 - numZomb); //random para creacion de ciudadanos
        for(int i = 0; i < numCiudd; i++) //for para creacion de ciudadanos
        {
            ciudadano = GameObject.CreatePrimitive(PrimitiveType.Cube);
            ciudadano.AddComponent<Ciudadano>();
            ciudadano.transform.position = ciudadano.GetComponent<Ciudadano>().ubic;
            ciudadano.AddComponent<Rigidbody>();
            ciudadano.name = "Ciudadanito";
        }
    }
}
