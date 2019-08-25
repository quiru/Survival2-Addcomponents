using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombii : MonoBehaviour
{
    public DatosZombi utilZombii;
    public Vector3 mov;
    public int cambiaMov;

    void Awake()
    {
        int numColor = Random.Range(1, 4);
        switch (numColor)
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

        int darGusto = Random.Range(0, 5);
        utilZombii.queComer = (DatosZombi.Gusto)darGusto;
        mov = new Vector3(Random.Range(1, 20), 0.5f, Random.Range(1, 20));
        cambiaMov = 0;
    }

    void Start()
    {
        utilZombii.estado = (DatosZombi.Estados)0;
        
        StartCoroutine("cambioEstado");
    }

    void Update()
    {
        switch (utilZombii.estado)
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

    IEnumerator cambioEstado()
    {
        while (true)
        {
            if (utilZombii.estado == (DatosZombi.Estados)0)
            {
                utilZombii.estado = (DatosZombi.Estados)1;
                cambiaMov = Random.Range(0, 5);
            }
            else
            {
                utilZombii.estado = (DatosZombi.Estados)0;
            }
            yield return new WaitForSeconds(5);
        }
    }
}

public struct DatosZombi
{
    public Color colorZombi;

    public enum Gusto
    {
        culito, deditos, uñas, teticas, homoplato
    }
    public Gusto queComer;

    public enum Estados
    {
        idle, moving
    }
    public Estados estado;
}




