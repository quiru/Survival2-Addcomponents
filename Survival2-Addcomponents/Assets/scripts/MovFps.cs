using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFps : MonoBehaviour
{
    float vel;
    DatosHero utilVel;
    float mouseX;

    void Start()
    {
        utilVel.velhero = Random.Range(1f, 2f);
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

    // Update is called once per frame
    void Update()
    {
        //transform.position += movimiento();
        mouseX += Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, mouseX, 0);
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * utilVel.velhero * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * utilVel.velhero * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * utilVel.velhero * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * utilVel.velhero * Time.deltaTime;
        }
    }
}
