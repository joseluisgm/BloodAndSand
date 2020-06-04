using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoEnemigo : MonoBehaviour
{

    public GameObject DE1;
    public GameObject DE2;
    public GameObject DE3;
    public GameObject posDisparo1;
    public GameObject posDisparo2;
    public GameObject posDisparo3;
    public static int vida = 15;
    GameObject spawn;
    GameObject spawn2;
    GameObject spawn3;
    float temp = 0;
    float temp1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        temp1 = 500;
        spawn = posDisparo1;
        spawn2 = posDisparo2;
        spawn3 = posDisparo3;
        temp = temp1;
    }

    // Update is called once per frame
    void Update()
    {
        if (temp > 0)
        {
            temp--;
            if (temp == 0)
            {
                disparar();
                temp = temp1;
            }
        }
       
    }

    private void disparar()
    {
        
           Instantiate(DE1, spawn.transform.position, transform.rotation);
           Instantiate(DE2, spawn2.transform.position, transform.rotation);
           Instantiate(DE3, spawn3.transform.position, transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "disparo")
        {
            vida -= 1;
            if (vida <= 0) {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }

        if (other.gameObject.tag == "Player")
        {
            mover.vida -= 1;
        }
    }
}
