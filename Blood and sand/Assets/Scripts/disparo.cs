using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public static float v = 5f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(v, 0f, 0f);
        StartCoroutine(eliminar(2f));
    }

    IEnumerator eliminar(float s)
    {
        yield return new WaitForSeconds(s);
        Destroy(gameObject);
    }
}
