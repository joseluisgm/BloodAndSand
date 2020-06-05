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
    public Image jugador;
    public static float vida;
    public static float vidaMaxima=5;
    public static float oro=0;
    public Button bntC;
    public Button bntS;
    public Button bntM;
    public GameObject camara;
    void Start()
    {
        vida = vidaMaxima;
        txtMuerto.enabled = false;       
        bntM.gameObject.SetActive(false);
        bntC.gameObject.SetActive(false);
        bntS.gameObject.SetActive(false);
        bntM.enabled = false;
        bntC.enabled = false;
        bntS.enabled = false;
        spawn = posDisparo1;
    }
    // Update is called once per frame
    void Update()
    {
        direccion();
        disparar();
        estado();
        seguirCamara();
    }

    private void seguirCamara()
    {
        camara.gameObject.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x,gameObject.transform.transform.position.y+2,0), Quaternion.identity);
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
            Vector3 lTemp = jugador.transform.localScale;
            lTemp.x = 1;
           jugador.transform.localScale = lTemp;
            disparo.v = -5f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector2( v * Time.deltaTime,0));
            spawn = posDisparo1;
            Vector3 lTemp = jugador.transform.localScale;
            lTemp.x = -1;
            jugador.transform.localScale = lTemp;
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
        if (Time.timeScale == 1)
        {           
            Time.timeScale = 0;
            bntC.enabled = true;
            bntS.enabled = true;
            bntM.enabled = true;
            bntC.gameObject.SetActive(true);
            bntS.gameObject.SetActive(true);
            bntM.gameObject.SetActive(true);
        }
        else if (Time.timeScale == 0)
        {
            bntC.gameObject.SetActive(false);
            bntS.gameObject.SetActive(false);
            bntM.gameObject.SetActive(false);
            bntM.enabled = false;
            bntC.enabled = false;
            bntS.enabled = false;
            Time.timeScale = 1;
        }
        

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
        bntS.enabled = true;
        bntS.gameObject.SetActive(true);
    }

    public static void guardar()
    {
        PlayerPrefs.SetFloat("vida", vida);
        PlayerPrefs.SetFloat("vidaMaxima", vidaMaxima);
        PlayerPrefs.SetFloat("oro", oro);
        PlayerPrefs.SetFloat("v", v);
        PlayerPrefs.SetFloat("s", s);
    }

    public static void cargar() 
    {
        PlayerPrefs.GetFloat("vida", vida);
        PlayerPrefs.GetFloat("vidaMaxima", vidaMaxima);
        PlayerPrefs.GetFloat("oro", oro);
        PlayerPrefs.GetFloat("v", v);
        PlayerPrefs.GetFloat("s", s);
    }

    public static void reseteo()
    {
        vidaMaxima = 5;
        v = 5;
        s = 6.5f;
        vida = 5;
        oro = 0;
    }

}
