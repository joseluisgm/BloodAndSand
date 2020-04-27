using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class mover : MonoBehaviour
{
    // Start is called before the first frame update
    float v = 5;
    float s = 6.5f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        direccion();
    }
    private void direccion()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector2(0, s * Time.deltaTime));          
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector2( -v * Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector2( v * Time.deltaTime,0));
        }
    }

}
