using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //evento que cuando la hitbox de la vida colisiona con el jugador le da vida si le falta 
        if (other.gameObject.tag == "Player")
        {
            if (mover.vida != mover.vidaMaxima)
            {
                mover.vida += valor;
                if (mover.vida > mover.vidaMaxima)
                {
                    mover.vida = mover.vidaMaxima;
                }
                Destroy(gameObject);
            }          
           
        }
    }
}
