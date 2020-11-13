using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{   
    public Vector3 force1;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody>().AddForce(force1*100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(1,0,0);
    }
}
