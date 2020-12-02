using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class mover : MonoBehaviour
{
    // Start is called before the first frame update
    /*v es la velocidad del jugador 
     *s es la fuerza del salto
     *proyectil es el objeto que invocamos desde el juego
     *posDisparo1,2 es donde aparecera del objeto
     *spawn es la primera posicion del objeto
     * txtVida,oro,Muerto , son los labes de la interfaz grafica
     * image jugador es la imagen del jugador
     * float vida,vidaMaxima,oro son los valores numericos del jugador
     * button bntC,S,M son los botones de la interfaz grafica 
     * gameObject camara es la camara que sigue al jugador por todo el escenario
     */
    public static float v = 5;
    public static float s = 300f;
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
    private Rigidbody m_Rigidbody;
    int contador = 0;
    int municion = 0;
    
    void Start()
    {
        //pirmero ocultamos los botones y los textos que no necesitamos , damos valores a la vida y la vida maxima 
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
        //esta funcion sigue al jugador con la camara todo el rato 
        camara.gameObject.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x,gameObject.transform.transform.position.y+2,0), Quaternion.identity);
    }
    private void direccion()
    {
        //funcion que hace que el jugador pueda moverse actualizando la imagen cada vez que se mueve y el punto de disparo , tambien saltar
        if (Input.GetKeyDown(KeyCode.W)) 
        {
          
            if (contador < 2) {
                this.transform.Translate(new Vector2(0, s * Time.deltaTime));
                contador++;

            }
           


        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector2( -v * Time.deltaTime,0));
            spawn = posDisparo2;
            Vector3 lTemp = jugador.transform.localScale;
            lTemp.x = -1;
           jugador.transform.localScale = lTemp;
            disparo.v = -5f;
        }

        if (Input.GetKey(KeyCode.D))
        {
          
            this.transform.Translate(new Vector2( v * Time.deltaTime,0));
            spawn = posDisparo1;
            Vector3 lTemp = jugador.transform.localScale;
            lTemp.x = 1;
            jugador.transform.localScale = lTemp;
            disparo.v = 5f;
        }
        //restablece el contador de la municion 
        if (Input.GetKeyDown(KeyCode.R))
        {
            municion=0;
        }
        
    }

    private void disparar()
    {
        //funcion que cuando pulsas la telca E invoca un proyectil y para limitar su  uso  solo lo invoca 10 veces 
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(municion < 5) {
                Instantiate(proyectil, spawn.transform.position, transform.rotation);
                municion++;
            }
           


        }
    }


    public void btnpausa()
        //boton que pausa el juego y enseña el menu de pausa 
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
        //funcion que comprueba todo el rato el estado del jugador 
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
        //funcion que cuando la vida llega a 0 se activa haciendo un perder 
    {
        txtOro.enabled = false;
        txtVida.enabled = false;
        txtMuerto.enabled = true;
        bntS.enabled = true;
        bntS.gameObject.SetActive(true);
    }

    public static void guardar()
        //funcion que guarda los datos del jugador en la base de datos interna de Unity
    {
        PlayerPrefs.SetFloat("vida", vida);
        PlayerPrefs.SetFloat("vidaMaxima", vidaMaxima);
        PlayerPrefs.SetFloat("oro", oro);
        PlayerPrefs.SetFloat("v", v);
        PlayerPrefs.SetFloat("s", s);
    }

    public static void cargar()
    //funcion que carga los datos del jugador en la base de datos interna de Unity
    {
        PlayerPrefs.GetFloat("vida", vida);
        PlayerPrefs.GetFloat("vidaMaxima", vidaMaxima);
        PlayerPrefs.GetFloat("oro", oro);
        PlayerPrefs.GetFloat("v", v);
        PlayerPrefs.GetFloat("s", s);
    }

    public static void reseteo()
    {
        //funcion que resetea los valores del jugador para empezar de nuevo 
        vidaMaxima = 5;
        v = 5;
        s = 6.5f;
        vida = 5;
        oro = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        // evento para limitar salto
        if (other.gameObject.tag == "suelo")
        {
            contador = 0;

        }
    }


   


}
