using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersPersonal : MonoBehaviour
{
    DatosZombi utilZombi; //variable tipo estructura de zombi

    DatosCiudd utilCiud; //variable tipo estructura de ciudadano
    

    void OnCollisionEnter(Collision colision) //funcion onCollision para dar mensaje cuando el heroe toca algun personaje
    {
        if(colision.transform.name == "Zombi") 
        {
            utilZombi = colision.gameObject.GetComponent<Zombii>().utilZombii; //obtiene el dato de tipo estructura y lo asigna a utilZombi
            Debug.Log("waaarrrr quiero comer "+ utilZombi.queComer);
        }
        else if(colision.transform.name == "Ciudadanito")
        {
            utilCiud = colision.gameObject.GetComponent<Ciudadano>().utilCiudd; //obtiene el dato de tipo estructura y lo asigna a util
            Debug.Log("hola soy "+ utilCiud.varNombrs + " y tengo " + utilCiud.edadCiudd);
        }
    }
}

public struct DatosHero //estructura para guardar los datos del heroe
{
    public float velhero;
}
