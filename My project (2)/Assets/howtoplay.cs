using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoplay : MonoBehaviour
{
    public Vector3 spot;
    public float ms;
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*ms);
    }
    public void increaseSpeed()
    {
        ms = 1.5f;
    }
}
