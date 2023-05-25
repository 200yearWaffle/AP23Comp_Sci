using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increase : MonoBehaviour
{
    public float ms;
    public Vector3 f;
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.01f;
        f = new Vector3(10.0f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*ms);
        if(transform.position.x < -10){
            transform.position = f;
        }
        if(Input.GetKey("w"))
        {
            ms=0.5f;
        }
        if(Input.GetKey("s"))
        {
            ms=0.01f;
        }
        if(Input.GetKeyDown("u"))
        {
            ms=ms+0.01f;
        }
        if(Input.GetKeyDown("d"))
        {
            ms=ms-0.01f;
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            ms=ms+0.1f;
        }
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            ms=ms-0.1f;
        }
    }
    public void increaseSpeed()
    {
        ms = 0.5f;
    }
}
