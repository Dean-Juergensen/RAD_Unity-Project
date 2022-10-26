using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    Rigidbody ourRigidBody;
    ParticleSystem particle;
    public GameObject destructionObject;
 
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        ourRigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        SnowballReact objectHitDetected = collision.gameObject.GetComponent<SnowballReact>();
        if(objectHitDetected)
        {
            particle.Play();  
            Destroy(destructionObject, particle.main.duration);
 
           
            Health objectHitHealth  = collision.gameObject.GetComponent<Health>();

                if(objectHitHealth)
              {
                   print("Found Health script in object hit");
                   objectHitHealth.takeDamage(10);

                  int ObjectsMaximumHealth = objectHitHealth.whatsYourMaxHealth();
                   if (ObjectsMaximumHealth > 100)
                       objectHitHealth.takeDamage(100);

             }
              else
             {
                 print("Didn't find Heath script in object hit");
              }
        }
        else
        {
 
        }
  
    }
}
// particle code from https://learn.unity.com/tutorial/introduction-to-particle-systems#6025fdd9edbc2a112d4f0137