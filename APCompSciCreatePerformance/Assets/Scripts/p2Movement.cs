using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class p2Movement : MonoBehaviour
{
    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;
    public Text p1Text;
   public int p1Health;
    public Rigidbody rb;
    public float speed;
    public Scene currentscene;
    public Collider boxCollider;
    void Start() //Initiates the Vairables...Only runs at the Start of the Game
    {
        
        p1Health = 5;                        //Makes Player 1's Health 10
        rb.useGravity = false;   //disables Gravity on the RigidBody
        rb.drag = 1;        //Sets Drag to 1
        rb.isKinematic = false;  //Disables kinematic movement
        

    }
    private void OnTriggerEnter(Collider other)//Checks for the Collision with a Trigger
    {
        GameObject Maleplayer= GameObject.Find("Maleplayer");
        pMovement script = Maleplayer.GetComponent<pMovement>();
        if (other.gameObject.tag == "lightMed")//if the tag of the collision is "lightMed", the player will gain one health and the lightMed will be destroyed
        {
            script.p2Health++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "heavyMed")  //if the tag of the collision is "heavyMed", the player will gain two health and the heavyMed will be destroyed
        {
            script.p2Health = script.p2Health + 2;
            Destroy(other.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)   //Checks for Collision
    {
        Debug.Log("collision detected on player 2");
        if(Input.GetKey(KeyCode.L)){                        //Allows player to hit and modifies the opposing Player's Health
            if (collision.gameObject.tag == "player1")
            {
                p1Health--;
                Debug.Log("Player 1 was hit");
            }
        }
    }

    void FixedUpdate()           //Main Function that updates every frams

    {

        p1Text.text = "P1 Health = " + p1Health.ToString();//Makes the text on the UI display player 1's health 

        currentscene = SceneManager.GetActiveScene();           //Only allows pLayer to move on the BattleScreen
        if (currentscene.name == "BattleScreen")
        {
            playerMovement();


        }
        if (p1Health == 0) { SceneManager.LoadScene("P2Win"); }   //Switches to win screen upon game end



    }
    void playerMovement()       //Movement Function
    {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, XMin, XMax), (Mathf.Clamp(transform.position.y, YMin, YMax)));//Limits the Position of to the Game Window
        if (Input.GetKey(KeyCode.UpArrow))                                                  
        {
            rb.AddForce(Vector3.up * speed * Time.deltaTime,ForceMode.VelocityChange);              //Moves player up
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.VelocityChange);              //Moves player left
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.down * speed * Time.deltaTime, ForceMode.VelocityChange);              //Moves player down
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.VelocityChange);              //Moves player right
        }




    }

}
