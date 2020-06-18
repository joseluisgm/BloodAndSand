using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    /*
     * puntoA,B son los puntos en el mapa en el cual el enemigo se movera 
     * float velocidad es la velocidad a la que ira el enemigo
     * vector3 destino es cuando llega a un punto se cambia el destino al contrario
     */
    public GameObject puntoA;
    public GameObject puntoB;
    Vector3 destino;
    float velocidad = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // cuando se inica se le dice a que punto ir en este caso es el A
        destino = puntoA.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //si el enemigo llega al punto a o b se cambia su destino hacia el otro punto 
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
        // evento cuando el enemigo colisiona con con proyectil desaparece y cuando colisiona con el jugador le baja vida 
        if (other.gameObject.tag == "disparo")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }

        if (other.gameObject.tag == "Player")
        {
            mover.vida -= 1;
        }
    }




}
