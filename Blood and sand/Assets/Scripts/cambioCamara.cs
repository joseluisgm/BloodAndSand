using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioCamara : MonoBehaviour
{
    public GameObject camara;
    public GameObject camara2;

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
        if (other.tag == "Player")
        {
            if (camara.activeSelf == true) {
                camara.SetActive(false);
                camara2.SetActive(true);
            }
            else
            {
                camara2.SetActive(false);
                camara.SetActive(true);
            }
           
        }
    }

}
