using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public float speed = 0.0f;
    public float time = 2.0f;
    public float distance = 100.0f;

        public int lives = 4;
    public bool Alive = true;

    // Start is called before the first frame update
    void Start()
    {
        speed = distance / time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
