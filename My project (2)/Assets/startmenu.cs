using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmenu : MonoBehaviour
{
    public float ms;
    public Vector3 f;
    // Start is called before the first frame update
    void Start()
    {
        ms = 0.0f;
        f = new Vector3(transform.position.x, transform.position.y, transform.position.z);
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
