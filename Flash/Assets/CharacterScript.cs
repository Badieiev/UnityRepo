using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public GameObject bulletCloneTemplate; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= Time.deltaTime;
        }
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletCloneTemplate, transform.position, transform.rotation);
        }
    }
}
