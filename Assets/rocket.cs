using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public Transform planet; //трансформ планеты на которой стоим
    public int acceleration;
     private Rigidbody rb;  //физика гг
    public Transform tr; //его трансформ
    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody>(); //кешируем физику гг
        tr=this.GetComponent<Transform>();   //кешируем трансформ ггs
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))    //при клике
         {
             if(this.rb.velocity.magnitude==0)  // если стоим
                    {
                        rb.isKinematic=false;              //включаем физику
                        Vector3 vector = (tr.position-planet.position);  //вычисляем направление полета
                        rb.AddForce(vector*acceleration);; //придаем импульс гг
                        tr.SetParent(null);    //отпускаем от планеты гг
                        //  planet=null;
                    }
         }
    }
}
