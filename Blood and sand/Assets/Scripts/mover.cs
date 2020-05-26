using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class mover : MonoBehaviour
{
    // Start is called before the first frame update
    public static float v = 5;
    public static float s = 6.5f;
    public GameObject proyectil;
    public GameObject posDisparo1;
    public GameObject posDisparo2;
    GameObject spawn;
    public Text txtVida;
    public Text txtOro;
    public Text txtMuerto;
    public static float vida;
    public static float vidaMaxima=5;
    public static float oro=0;

    void Start()
    {
        vida = vidaMaxima;
        txtMuerto.enabled = false;
        spawn = posDisparo1;
    }
    // Update is called once per frame
    void Update()
    {
        direccion();
        disparar();
        estado();
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(proyectil,spawn.transform.position,transform.rotation);
        }
    }


    public void btnpausa()
    {
        Time.timeScale = 0;
    }

    private void estado()
    {
        txtVida.text = "vida: " + vida;
        txtOro.text = "Oro: " + oro;
        if (vida <= 0)
        {
            perder();
            Destroy(gameObject);
        }
    }
    private void perder()
    {
        txtOro.enabled = false;
        txtVida.enabled = false;
        txtMuerto.enabled = true;

    }
}
