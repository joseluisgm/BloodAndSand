using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambioAJuego()
    {
        /*
         *esta funcion es la que cambia del menu de inicio al juego y resetea todo el progreso 
         */
        Time.timeScale = 1;
        PlayerPrefs.DeleteAll();
        mover.reseteo();
        SceneManager.LoadScene("SampleScene");
       
    }
    public void cambioAJuegoAmedias()
    {
        /*
         *esta funcion es la que cambia del menu de inicio al juego y carga el progreso del playerPrefs
         */
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        mover.cargar();
    }
    public void cambioAMenu()
    {
        /*
         *esta funcion es la que cambia del juego al menu y guarda todo el progreso 
         */
        Time.timeScale = 1;
        mover.guardar();
        SceneManager.LoadScene("inicio");
    }

    public void cambioAudio()
    {
        /*
         *esta funcion es la que cambia el sonido a apagado o encendido 
         */
        if (  AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        }else if (AudioListener.volume == 1){
            AudioListener.volume = 0;
        }
    }

    public void salir()
    {
        /*
         *esta funcion es la que cierra el juego 
         */
        Application.Quit();
    }
}
