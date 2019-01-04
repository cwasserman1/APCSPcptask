using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class p2Movement : MonoBehaviour
{
    public Text p1Text;
    public int p1Score=10;
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
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        currentscene = SceneManager.GetActiveScene();
        if (currentscene.name == "BattleScreen")
        {
            playerMovement();


        }
        float restrictX = Mathf.Clamp(pos.x, -8.21f, 8.35f);

    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision detected on player 2");
        if(Input.GetKeyUp(KeyCode.L)){
            if (collision.gameObject.tag == "player1")
            {
                Debug.Log("HIT");
            }
        }
    }
    void playerMovement()
    {
   
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * speed * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.down * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.VelocityChange);
        }




    }

}
