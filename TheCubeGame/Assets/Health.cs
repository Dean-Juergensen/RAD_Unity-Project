using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    int CHP;
    public int MHP = 100;

    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            takeDamage(12);
    }

    // Function for taking damage
    internal void takeDamage(int damage)
    {
        CHP -= damage;
        print("Ouch you hurt me my health is now" + CHP);
        if(CHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    internal int whatsYourMaxHealth()
    {
        return MHP;
    }
}
