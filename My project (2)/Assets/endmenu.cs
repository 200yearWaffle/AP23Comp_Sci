using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endmenu : MonoBehaviour
{
    public float ms;
    public Vector3 p;
    public double counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 5;
        ms = 0f;
        p = new Vector3(-10f, 89f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector3.right*ms);
            if(transform.position.x > -10)
            {
                transform.position = p;
                ms=0f;
            }
            if(counter==0)
            {
                ms=1.5f;
            }
    }
    public void OnCollisionEnter2D(Collision2D coll)
    {
        counter = counter -1;
    }
    public void OnTriggerEnter2D(Collider2D coll)
    {
        print("Collision Detected");
        counter = counter -1;
    }
    public void increaseSpeed()
    {
        ms = 1.5f; 
    }
}
