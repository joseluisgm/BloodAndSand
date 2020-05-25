using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DE3 : MonoBehaviour
{
    public static float v = -2f;
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
        StartCoroutine(Eliminar(5f));
    }

    IEnumerator Eliminar(float s)
    {
        yield return new WaitForSeconds(s);
        Destroy(gameObject);
    }
}
