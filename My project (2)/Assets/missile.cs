using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    public float ms;
    public Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.0f;
        p = new Vector3(transform.position.x,transform.position.y,-5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*ms);
        if(transform.position.x > 140){
            transform.position = p;
        }
    }
     public void increaseSpeed()
    {
        ms = 0.03f;
    }
}
