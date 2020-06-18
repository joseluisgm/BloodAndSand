using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mejoraSTienda : MonoBehaviour
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
        //evento que cuando la hitbox de la mejora de salto colisiona con el jugador y tiene oro compra la mejora de salto
        if (other.gameObject.tag == "Player")
        {
            if (mover.oro >= 100)
            {
                mover.oro -= 100;
                mover.s += mover.s;
            }
        }


        
    }
}
