using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DE1 : MonoBehaviour
{
    public static float v = -10f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //al principio se le da un rig body al objeto 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //se le añade la fuerza al objeto y despues empieza una cuenta atras que eliminara al objeto
        rb.AddForce(v, 0f, 0f);
        StartCoroutine(Eliminar(1f));
    }
    //elimina el objeto cuando la cuenta llege a 0
    IEnumerator Eliminar(float s)
    {
        yield return new WaitForSeconds(s);
        Destroy(gameObject);
    }
    //evento on trigger cuando la hitbox es colisionada 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "disparo")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }

        if (other.gameObject.tag == "Player")
        {
            mover.vida -= 1;
            Destroy(gameObject);
        }
    }
}
