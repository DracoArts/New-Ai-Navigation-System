using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
      public   float speed=4f;



    void Update()
    {
        
        float h= Input.GetAxis("Horizontal");
        float v= Input.GetAxis("Vertical");

        Vector3 move= new Vector3(h,0,v);

        transform.Translate(move);

    }
}
