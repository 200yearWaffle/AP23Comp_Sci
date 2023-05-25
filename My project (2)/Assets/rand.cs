using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rand : MonoBehaviour
{
    public float ms;
    public float ds;
    public Vector3 f;
    // Start is called before the first frame update
    void Start()
    {
      ms = Random.Range(-10,10);
      ds = Random.Range(-10,10);
      f = new Vector3(ms,ds,ms);
    }

    // Update is called once per frame
    void Update()
    {
        ms = Random.Range(-10,10);
        ds = Random.Range(-10,10);
        f = new Vector3(ms,ds,ms);
        transform.position = f;
    }
}
