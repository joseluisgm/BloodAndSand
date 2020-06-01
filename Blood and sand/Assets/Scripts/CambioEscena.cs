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
        Time.timeScale = 1;
        PlayerPrefs.DeleteAll();
        mover.reseteo();
        SceneManager.LoadScene("SampleScene");
       
    }
    public void cambioAJuegoAmedias()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        mover.cargar();
    }
    public void cambioAMenu()
    {
        Time.timeScale = 1;
        mover.guardar();
        SceneManager.LoadScene("inicio");
    }

    public void cambioAudio()
    {
      if(  AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        }else if (AudioListener.volume == 1){
            AudioListener.volume = 0;
        }
    }

    public void salir()
    {
        Application.Quit();
    }
}
