using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersPersonal : MonoBehaviour
{
    DatosZombi utilZombi;

    DatosCiudd utilCiud;
    void Start()
    {
        
    }

    /*Vector3 movimiento()
    {
        
        Vector3 mov = Vector3.zero;
        if(Input.GetKey(KeyCode.A))
        {
            mov.x -= vel;
        }
        if(Input.GetKey(KeyCode.D))
        {
            mov.x += vel;
        }
        if(Input.GetKey(KeyCode.S))
        {
            mov.z -= vel;
        }
        if(Input.GetKey(KeyCode.W))
        {
            mov.z += vel;
        }
        return mov;
    }*/
    /*void Update()
    {
        objPersonaje.transform.position += movimiento();
    }*/

    void OnCollisionEnter(Collision colision)
    {
        if(colision.transform.name == "Zombi")
        {
            utilZombi = colision.gameObject.GetComponent<Zombii>().utilZombii;
            Debug.Log("waaarrrr quiero comer "+ utilZombi.queComer);
        }
        else if(colision.transform.name == "Ciudadanito")
        {
            utilCiud = colision.gameObject.GetComponent<Ciudadano>().utilCiudd;
            Debug.Log("hola soy "+ utilCiud.varNombrs + " y tengo " + utilCiud.edadCiudd);
        }
    }
}

public struct DatosHero
{
    public float velhero;
}
