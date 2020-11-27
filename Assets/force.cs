using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{   
    public int acceleration;
    public Vector3 force1;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody>().AddForce(force1*acceleration, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
       // transform.Rotate(1,0,0);
    }
}
