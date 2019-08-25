using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    GameObject heroe;
    GameObject zombi;
    DatosZombi utilZombi;
    
    void Start()
    {
        heroe = GameObject.CreatePrimitive(PrimitiveType.Cube);
        heroe.AddComponent<PersPersonal>();
        heroe.AddComponent<MovFps>();
        heroe.AddComponent<Rigidbody>();
        GameObject movCam = new GameObject();
        movCam.AddComponent<Camera>();
        movCam.AddComponent<CamFps>();
        movCam.transform.SetParent(heroe.transform);
        heroe.transform.position = new Vector3(Random.Range(1, 21), 0.5f, Random.Range(1, 21));

        int numZomb = Random.Range(9, 20);
        for (int i = 0; i < numZomb; i++)
        {
            
            zombi = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //zombi.transform.position = new Vector3(Random.Range(1, 21), 0.5f, Random.Range(1, 21));
            zombi.AddComponent<Zombii>();
            zombi.transform.position = zombi.GetComponent<Zombii>().mov;
            utilZombi = zombi.GetComponent<Zombii>().utilZombii;
            zombi.GetComponent<Renderer>().material.color = utilZombi.colorZombi;
            zombi.AddComponent<Rigidbody>();
            zombi.name = "Zombi";
        }
    }
    void Update()
    {
        
    }
}
