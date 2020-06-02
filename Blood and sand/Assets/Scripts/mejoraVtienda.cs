using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mejoraVtienda : MonoBehaviour
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
        if (mover.oro == 100)
        {
            mover.oro -= 100;

            if (other.gameObject.tag == "Player")
            {
                mover.vidaMaxima += 5;
                mover.vida = mover.vidaMaxima;                
            }


        }
    }
}
