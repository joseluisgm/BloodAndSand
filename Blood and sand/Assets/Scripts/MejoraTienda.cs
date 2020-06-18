using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MejoraTienda : MonoBehaviour
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
        //evento que cuando la hitbox de la mejora de velocidad colisiona con el jugador y tiene oro compra la mejora de velocidad

        if (other.gameObject.tag == "Player")
            {
            if (mover.oro >= 100)
            {
                mover.oro -= 100;
                mover.v += 1;

            }


        }
    }
}
