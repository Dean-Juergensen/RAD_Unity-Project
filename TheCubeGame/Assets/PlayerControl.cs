using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float turningSpeed = 180;
    Rigidbody ourRigidBody;
    public Transform SnowballTemplate;
    private float timerJump = 1;
    private float waitTimeJump = 1;
    private double timerThrow = 0.25;
    private double waitTimeThrow = 0.25;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
        timerJump = Time.time;
        timerThrow = Time.time;
}

    // Update is called once per frame
    void Update()
    {
        if (timerJump < waitTimeJump)
        { }
        else if (Input.GetKeyDown(KeyCode.Space))
            {
                ourRigidBody.AddExplosionForce(400, transform.position + Vector3.down, 2);
                timerJump = 0;
            }
        timerJump += Time.deltaTime;
        
        //        if (Input.GetKey(KeyCode.LeftControl))
        //    transform.position -= transform.up * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            transform.position += 5 * transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= 5 * transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position += transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.position -= transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);

        // if (Input.GetKey(KeyCode.Z))
        //  transform.Rotate(Vector3.right, turningSpeed * Time.deltaTime);

        // if (Input.GetKey(KeyCode.X))
        //  transform.Rotate(Vector3.right, -turningSpeed* Time.deltaTime);

        if (timerThrow < waitTimeThrow)
        { }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            Transform SB = Instantiate(SnowballTemplate, transform.position + transform.forward + 2*transform.up, transform.rotation);
            Rigidbody projectileSB = SB.GetComponent<Rigidbody>();
            projectileSB.useGravity = true;
            projectileSB.AddExplosionForce(2000, SB.transform.position - 2*SB.transform.forward, 3); // SB.transform.up -
            timerThrow = 0;
        }
        timerThrow += Time.deltaTime;
    }
}
