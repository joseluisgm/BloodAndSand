using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaTienda : MonoBehaviour
{
    public int valor = 0;
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
        if (mover.oro == 10)
        {
            mover.oro -= 10;

            if (mover.vida != mover.vidaMaxima)
            {
                mover.vida += valor;
                if (mover.vida > mover.vidaMaxima)
                {
                    mover.vida = mover.vidaMaxima;
                }
            }


        }
    }
}