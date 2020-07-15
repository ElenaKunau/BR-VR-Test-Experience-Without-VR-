using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour

{
    //movement speed in units per second
    //private float speed = 1f;
    int speedAmt =20;

    void Start () {

    }

    void Update()
    {
     //if(transform.position.x<= -6){
        //speedAmt =10;
      //}
      //if(transform.position.x<= -6){
        //speedAmt = -10;
      //}
    //transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 3), transform.position.y, transform.position.z);
   transform.Translate (speedAmt*Time.deltaTime, 0,0);
    }
}
