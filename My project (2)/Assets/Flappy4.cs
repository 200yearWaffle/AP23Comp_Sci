using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flappy4 : MonoBehaviour
{
    public float ms;
    public Text obj;
    int counter;
    public Vector3 f; 
    public Vector3 d; 
    // Start is called before the first frame update
    void Start()
    {
        counter = 5;
        obj.text = counter.ToString();
        ms = 0.03f;
        f = new Vector3(-10.0f,-10.0f,-10.0f);
        d = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        obj.text = counter.ToString();
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up*ms);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.down*ms);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        counter = counter -1;
        if(counter==0){
           transform.position = f;
           transform.position = d;
           counter = 6;
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        print("Collision Detected");
        counter = counter -1;
        if(counter==0){
           transform.position = f;
           transform.position = d;
           counter = 6;
        }
    }
}
