using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy5 : MonoBehaviour
{
    public float ms;
    public Vector3 f;
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.1f;
        f = new Vector3(-30.0f,transform.position.y,-8.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*ms);
        if(transform.position.x > 80){
            transform.position = f;
        }
    }
}
