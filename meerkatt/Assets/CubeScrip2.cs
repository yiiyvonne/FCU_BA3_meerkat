﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScrip2 : MonoBehaviour
{

    public float speed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
        
    }
}
