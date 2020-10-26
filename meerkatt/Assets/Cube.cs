using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    Vector3 tempPos = Vector3.zero; //(0,0,0)
    int myVariable = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;
        tempPos.x = tempPos.x + 1f; //0.1 = 1f
        transform.position = tempPos;

        if (tempPos.x > 10f)
        {
            tempPos.x = 0f;
            transform.position = tempPos;
        }
    }
}
