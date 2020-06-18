using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MejoraVelocidad : MonoBehaviour
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
        //evento cuando colisiona con la mejora de velocidad se le aplica al jugador y se elimina del mapa 
        if (other.gameObject.tag == "Player")
        {
            mover.v += 3;         
            Destroy(gameObject);
        }
    }
}
