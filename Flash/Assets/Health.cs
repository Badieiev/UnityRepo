 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int MHP = 100;
    int CHP = 100;

    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void takeDamage (int howMuchDamage)
    {
        CHP -= howMuchDamage;
        logic.addScore();
        if (CHP <= 0)
        {
            Destroy(gameObject);
            logic.gameOver();
        }
    }
}
