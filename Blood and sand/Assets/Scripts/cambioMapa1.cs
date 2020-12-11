using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioMapa1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //evento triguer que funciona para cambiar al mapa que se indica en el String de loadScene
        if (other.gameObject.tag == "Player")
        {
            mover.guardar();
            mover.cargar();
            SceneManager.LoadScene("SampleScene_3");
        }


    }
}
