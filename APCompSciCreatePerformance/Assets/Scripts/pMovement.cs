using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public Scene currentscene;
    void Start()
    {
        rb.useGravity = false;
        rb.drag = 1;
        rb.isKinematic = false;
    }

   
    void FixedUpdate()
    {
        currentscene = SceneManager.GetActiveScene();
        if (currentscene.name == "BattleScreen")
        {
            playerMovement();
         

        }

    }
    void playerMovement()
    {
        
        Vector3 mousePos = Input.mousePosition;
        float XmousePos = Input.mousePosition.x;
        float YmousePos = Input.mousePosition.y;
        currentscene.ToString();
       
            if (Input.GetKey(KeyCode.W))
            {
            rb.AddForce(Vector3.up * speed * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.A))
            {
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.S))
            {
            rb.AddForce(Vector3.down * speed * Time.deltaTime,ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.D))
            {
            rb.AddForce(Vector3.right * speed * Time.deltaTime,ForceMode.VelocityChange);
            }




    }
}
