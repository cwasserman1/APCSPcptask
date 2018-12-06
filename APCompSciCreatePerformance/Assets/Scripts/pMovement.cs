using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb.useGravity = false;
        rb.drag = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerMovement();
    }
    void playerMovement()
    {
        Vector3 mousePos = Input.mousePosition;
        float XmousePos = Input.mousePosition.x;
        float YmousePos = Input.mousePosition.y;
        
        Debug.Log(mousePos);

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
       
    }
}
