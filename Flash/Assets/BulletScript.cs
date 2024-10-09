using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    LogicScript logic;
    float bulletSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        logic = FindAnyObjectByType<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletSpeed * transform.forward * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
        Health possibleVictim = collision.transform.GetComponent<Health>();
        if (possibleVictim)
        {
            possibleVictim.takeDamage(25);
            logic.addScore();
        }
    } 
}
