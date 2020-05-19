using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class mover : MonoBehaviour
{
    // Start is called before the first frame update
    float v = 5;
    float s = 6.5f;
    public GameObject proyectil;
    public GameObject posDisparo1;
    public GameObject posDisparo2;
    GameObject spawn;
    void Start()
    {
        spawn = posDisparo1;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        direccion();
        disparar();
    }
    private void direccion()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector2(0, s * Time.deltaTime));          
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector2( -v * Time.deltaTime,0));
            spawn = posDisparo2;
            disparo.v = -5f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector2( v * Time.deltaTime,0));
            spawn = posDisparo1;
            disparo.v = 5f;
        }
    }

    private void disparar()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(proyectil,spawn.transform.position,transform.rotation);
        }
    }

}
