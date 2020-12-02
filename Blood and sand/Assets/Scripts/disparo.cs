using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public static float v = 10f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //se crea un rigbody para el proyectil  
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //añade fuerza al proyectil y empieza el tempoizador de eliminar
        rb.AddForce(v, 0f, 0f);
        StartCoroutine(Eliminar(0.6f));
    }

    IEnumerator Eliminar(float s)
    {
        //cuando el temporizador interno llegue a 0 se elimina el proyectil 
        yield return new WaitForSeconds(s);
        Destroy(gameObject);
    }

     
}
