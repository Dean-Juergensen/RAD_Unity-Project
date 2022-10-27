using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float turningSpeed = 180;
    Rigidbody ourRigidBody;
    public Transform SnowballTemplate;
    private float timerJump = 1;
    private float waitTimeJump = 1;
    private double timerThrow = 0.25;
    private double waitTimeThrow = 0.25;
    private int number = 0;
    private double timerNumber = 1.5;
    private double waitTimerNumber = 1.5;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
        timerJump = Time.time;
        timerThrow = Time.time;
        timerNumber = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerNumber < waitTimerNumber)
        { }
        else
        { 
            number = Random.Range(0, 50); 
        }
        if (timerJump < waitTimeJump)
        { }
        else if (number >= 45 & number <= 50)
        {
            ourRigidBody.AddExplosionForce(400, transform.position + Vector3.down, 2);
            timerJump = 0;
        }
        timerNumber += Time.deltaTime;
        timerJump += Time.deltaTime;

        if (number >=40 & number <=44)
            transform.position += 5 * transform.forward * Time.deltaTime;

        if (number >= 35 & number <= 39)
            transform.position -= 5 * transform.forward * Time.deltaTime;

        if (number >= 30 & number <= 34)
            transform.position += transform.right * Time.deltaTime;

        if (number >= 25 & number <= 29)
            transform.position -= transform.right * Time.deltaTime;

        if (number >= 20 & number <= 24)
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (number >= 15 & number <= 19)
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);

        if (timerThrow < waitTimeThrow)
        { }
        else if (number == 2)
        {
            Transform SB = Instantiate(SnowballTemplate, transform.position + 2 * transform.forward + 2 * transform.up, transform.rotation);
            Rigidbody projectileSB = SB.GetComponent<Rigidbody>();
            projectileSB.useGravity = true;
            projectileSB.AddExplosionForce(2000, SB.transform.position - 2 * SB.transform.forward, 3); // SB.transform.up -
            timerThrow = 0;
        }
        timerThrow += Time.deltaTime;
    }
}
