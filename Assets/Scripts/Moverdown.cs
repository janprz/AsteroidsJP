﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverdown : MonoBehaviour
{

    private Rigidbody _rb;
    public int SpeedIndex;  
   
   // Class randomizes asteroids' moving trajectory.

    void Start () {
        Vector3 speed = new Vector3(Random.Range(-2,2), 0, Random.Range(-5,-2));
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = speed * SpeedIndex;
    }
	
}