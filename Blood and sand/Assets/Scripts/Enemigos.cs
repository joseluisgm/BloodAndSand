using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public GameObject puntoA;
    public GameObject puntoB;
    Vector3 destino;
    float velocidad = 2f;

    // Start is called before the first frame update
    void Start()
    {
        destino = puntoA.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position == puntoB.transform.position)
        {
            destino = puntoA.transform.position;
        }

        if (gameObject.transform.position == puntoA.transform.position)
        {
            destino = puntoB.transform.position;
        }

        Vector3 nueva_posicion = Vector3.MoveTowards(gameObject.transform.position, destino, velocidad * Time.deltaTime);
        gameObject.transform.position = nueva_posicion;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "disparo")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }




}
