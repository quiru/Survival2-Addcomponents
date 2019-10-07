using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombii : MonoBehaviour
{
    public DatosZombi utilZombii; //variable tipo estructura para utilizar los datos del zombi
    public Vector3 mov;
    public int cambiaMov; //variable para cambiar el movimiento

    void Awake()
    {
        int numColor = Random.Range(1, 4); //variable para dar color
        switch (numColor) //switch para dar color a el zombi segun numColor
        {
            case 1:
                utilZombii.colorZombi = Color.cyan;
                break;
            case 2:
                utilZombii.colorZombi = Color.magenta;
                break;
            case 3:
                utilZombii.colorZombi = Color.green;
                break;
        }

        int darGusto = Random.Range(0, 5); //variable para dar gusto
        utilZombii.queComer = (DatosZombi.Gusto)darGusto; //da gusto al zombi
        mov = new Vector3(Random.Range(1, 20), 0.5f, Random.Range(1, 20)); // vector para dar ubicacion
        cambiaMov = 0;
    }

    void Start()
    {
        utilZombii.estado = (DatosZombi.Estados)0;
        
        StartCoroutine("cambioEstado");
    }

    void Update()
    {
        switch (utilZombii.estado) //switch para mover el zombi segun estado
        {
            case DatosZombi.Estados.idle:
                transform.eulerAngles += new Vector3(0, 0.5f, 0);
                break;
            case DatosZombi.Estados.moving:
                if(cambiaMov == 0)
                {
                transform.position += new Vector3(0, 0, 0.04f);
                }
                else if(cambiaMov == 1)
                {
                    transform.position -= new Vector3(0, 0, 0.04f);
                }
                else if(cambiaMov == 2)
                {
                    transform.position -= new Vector3(0.04f, 0, 0);
                }
                else if(cambiaMov == 3)
                {
                    transform.position += new Vector3(0.04f, 0, 0);
                }
                break;
            default:
                break;
        }
    }

    IEnumerator cambioEstado() //corrutina para cambiar de estado cada 5 seg
    {
        while (true)
        {
            if (utilZombii.estado == (DatosZombi.Estados)0)
            {
                utilZombii.estado = (DatosZombi.Estados)1;
                cambiaMov = Random.Range(0, 4);
            }
            else
            {
                utilZombii.estado = (DatosZombi.Estados)0;
            }
            yield return new WaitForSeconds(5);
        }
    }
}

public struct DatosZombi //estructura para guardar los datos del zombi
{
    public Color colorZombi;

    public enum Gusto //enum para guardar gustos de zombi
    {
        culito, deditos, uñas, teticas, homoplato
    }
    public Gusto queComer; //variable de tipo enum para el gusto

    public enum Estados //enum para guardar estados
    {
        idle, moving
    }
    public Estados estado; //variable de tipo enum para los estados
}




