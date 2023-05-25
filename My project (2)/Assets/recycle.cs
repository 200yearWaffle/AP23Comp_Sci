using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    public float ms;
    public Vector3 f;
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.5f;
        f = new Vector3(20.0f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*ms);
        if(transform.position.x < -20){
            transform.position = f;
        }
    }
}
