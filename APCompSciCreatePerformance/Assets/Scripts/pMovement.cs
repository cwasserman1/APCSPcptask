using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class pMovement : MonoBehaviour

{
    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;
    
    public Rigidbody rb;
    public float speed;
    public int p2Health;
    public Text text;
    public Scene currentscene;
    
    private p2Movement script;
    void Start()//Initiates the Vairables...Only runs at the Start of the Game
    {
        
        p2Health = 5;                      //Makes Player 1's Health 10
        rb.useGravity = false;     //disables Gravity on the RigidBody
        rb.drag = 1;        //Sets Drag to 1
        rb.isKinematic = false; //Disables kinematic movement
    }

   
    void FixedUpdate()               //Main Function that updates every frams
    {
        if (p2Health == 0)
        {
            SceneManager.LoadScene("P1Win");         //Switches to win screen upon game end

        }
        text.text = "P2 Health = " + p2Health.ToString();           //Makes the text on the UI display player 1's health 
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        currentscene = SceneManager.GetActiveScene();

        if (currentscene.name == "BattleScreen")      
        {
            playerMovement();
         

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject femalePlayer = GameObject.Find("femalePlayer");
        p2Movement script = femalePlayer.GetComponent<p2Movement>();
        

        if (other.gameObject.tag == "lightMed") {

            script.p1Health++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "heavyMed")
        {
            script.p1Health = script.p1Health + 2;
            Destroy(other.gameObject);
        }
        
        
    }
    public void OnCollisionEnter(Collision collision)   //Checks for Collision
    {
        if (collision.gameObject.tag == "lightMed")
        {
            Debug.Log("Med REFILL");
            Destroy(collision.gameObject);
        }
        Debug.Log("collision detected on player 2");
        if (Input.GetKey(KeyCode.G))                        //Allows player to hit and modifies the opposing Player's Health
        {
            if (collision.gameObject.tag == "player2")
            {
                p2Health--;
                Debug.Log("Player 2 was hit");
            }
            
        }
    }
   
    void playerMovement()                       //Movement Function
    {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, XMin, XMax),(Mathf.Clamp(transform.position.y,YMin,YMax)));
        currentscene.ToString();
       
            if (Input.GetKey(KeyCode.W))
            {
            rb.AddForce(Vector3.up * speed * Time.deltaTime, ForceMode.VelocityChange);               //Moves player up
        }
            if (Input.GetKey(KeyCode.A))
            {
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.VelocityChange);              //Moves player left
        }
            if (Input.GetKey(KeyCode.S))
            {
            rb.AddForce(Vector3.down * speed * Time.deltaTime,ForceMode.VelocityChange);              //Moves player down
        }
            if (Input.GetKey(KeyCode.D))
            {
            rb.AddForce(Vector3.right * speed * Time.deltaTime,ForceMode.VelocityChange);             //Moves player right
        }




    }
}
