using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision collision)
    {
     Health objectHitHealth  = collision.gameObject.GetComponent<Health>();

        if(objectHitHealth)
        {
            print("Found Health script in object hit");
            objectHitHealth.takeDamage(3);

            int ObjectsMaximumHealth = objectHitHealth.whatsYourMaxHealth();
            if (ObjectsMaximumHealth > 100)
                objectHitHealth.takeDamage(100);

        }
        else
        {
            print("Didn't find Heath script in object hit");
        }
    }
}
