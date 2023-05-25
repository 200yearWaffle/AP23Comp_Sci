using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code2 : MonoBehaviour
{
    public float ms;
    public Vector3 f; 
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up*ms);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right*ms);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.down*ms);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left*ms);
        }
    }
}
