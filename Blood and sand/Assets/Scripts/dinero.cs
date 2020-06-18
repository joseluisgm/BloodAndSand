using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinero : MonoBehaviour
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
        //evento que cuando la hitbox del dinero colisiona con el jugador le da dinero
        if (other.gameObject.tag == "Player")
        {
            mover.oro += valor;
            Destroy(gameObject);
        }
    }
}
