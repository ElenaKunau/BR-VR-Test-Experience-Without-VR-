﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Transform B;
  public bool isMoving = false;

  float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
      var step = speed * Time.deltaTime;
        if(isMoving);
        {
          transform.position =  Vector3.MoveTowards (transform.position, B.position, step);
        }
    }
}
