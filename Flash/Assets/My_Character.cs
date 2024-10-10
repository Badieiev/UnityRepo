using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_Character : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*rb = GetComponent<Rigidbody>();
        if (rb != null) 
            print("Found Rigidbody");
        else
            print("Could not find rigidbody");



        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.left *  Time.deltaTime;*/
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y +=  Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -=  Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x +=  Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -=  Time.deltaTime;
        }
        transform.position = pos;
    }
}