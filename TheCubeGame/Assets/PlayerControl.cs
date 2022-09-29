using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float turningSpeed = 180;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            transform.position += transform.up * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftControl))
            transform.position -= transform.up * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position += transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.position -= transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Z))
            transform.Rotate(Vector3.right, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.X))
            transform.Rotate(Vector3.right, -turningSpeed* Time.deltaTime);
    }
}
