using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public float speed = 0.0f;
    public float time = 1.0f;
    public float distance = 100.0f;

    public int lives = 4;
    public bool Alive = ture;

    // Start is called before the first frame update
    void Start()
    {
        speed = distance / time;

        if (speed > 110 || speed < 70)
        {
            print("You are breaking the law !!");
        }

        print("you are traveling at " + speed);
    }

    // Update is called once per frame
    void Update()
    {

        SpeedCheck();

    }
    void SpeedCheck()
    {
        speed = distance / time;

        if (speed > 110 || speed < 70)
        {
            print("You are breaking the law !!");
        }

        print("you are traveling at " + speed);
    }
}
