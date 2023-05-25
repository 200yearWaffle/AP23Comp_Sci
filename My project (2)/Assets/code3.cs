using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code3 : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform listenerTransform;
    public float ms;
    public float rs;
    public float minDist = 0;
    public float maxDist = 25;
        public float dist; 
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.3f;
        rs = 0.3f;
        minDist = 0;
        maxDist = 25;
    }

    // Update is called once per frame
    void Update()
    {
        minDist = 0;
        maxDist = 25;
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
        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.forward, rs);
        }
        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.back, rs);
        }
        dist = Vector3.Distance(transform.position, listenerTransform.position);

        audioSource.volume = 1 - ((dist - minDist) / (maxDist - minDist));
    }
}
