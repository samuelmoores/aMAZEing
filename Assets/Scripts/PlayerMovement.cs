using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float rotateSpeed;
    public float jumpVelocity;
    Rigidbody rb;

    private float vInput;
    private float hInput;
    private float jump;
    private bool onGround;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * playerSpeed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        jump = Input.GetAxis("Jump") * jumpVelocity;
    }


    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        transform.Rotate(Vector3.up * hInput * Time.deltaTime);

        rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        

    }


}
