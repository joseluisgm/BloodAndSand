using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DE2 : MonoBehaviour
{
    public static float v = -7f;
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
        StartCoroutine(Eliminar(1.5f));
    }

    IEnumerator Eliminar(float s)
    {
        yield return new WaitForSeconds(s);
        Destroy(gameObject);
    }
}
