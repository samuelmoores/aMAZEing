using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    public float rotateSpeed = 5.0f;

    private Rigidbody rb;
    private Vector3 movementForce;

    float horizontal;
    float vertical;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        movementForce = new Vector3 (horizontal, 0, vertical);
        //rb.velocity = movementForce * playerSpeed;

       // Debug.Log("vertical: " + vertical);

    }


    private void FixedUpdate()
    {
        //rb.velocity = movementForce * Time.deltaTime;

        rb.AddForce(movementForce * playerSpeed);


        Debug.Log("movementForce: " + movementForce);
    }

    private void Move_GameOBJ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);


        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -(playerSpeed * Time.deltaTime));

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);


        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);


        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            playerSpeed = (playerSpeed * 3);

        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 5.0f;

        }
    }

}
