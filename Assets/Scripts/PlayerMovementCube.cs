using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCube : MonoBehaviour
{
    public float PlayerSpeed;
    public float RotateSpeed;
    public float Boost;
    float horizontal;
    float vertical;
    Vector3 InputDirection;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(2f, 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * PlayerSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -PlayerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -RotateSpeed * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerSpeed = PlayerSpeed * Boost;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PlayerSpeed = 5.0f;
        }

        //horizontal = Input.GetAxis("Horizontal");
        // vertical = Input.GetAxis("Vertical");
        //InputDirection = new Vector3(horizontal, 0.0f, vertical).normalized;
    }

    void FixedUpdate()
    {
       // Vector3 newVel = InputDirection * PlayerSpeed;
        //rb.velocity = new Vector3(newVel.x, 0f, newVel.z);
    }
}
