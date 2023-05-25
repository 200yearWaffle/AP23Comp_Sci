using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f22enemies : MonoBehaviour
{
    public float ms;
    public Vector3 f;
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.00f;
        f = new Vector3(transform.position.x,transform.position.y,-5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*ms);
        if(transform.position.x > 140){
            transform.position = f;
        }
    }
    public void increaseSpeed()
    {
        ms = 0.05f; 
    }
}