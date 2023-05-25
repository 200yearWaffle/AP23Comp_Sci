using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(temp, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
