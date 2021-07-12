using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class conciousMovement : MonoBehaviour
{
    public bool moving = false;
    public float moveSpeed = 0.3f;
    private Rigidbody2D rb;
    private bool isPlayer = true;
    private Vector2 movement;

    public float deathtime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Deathscene", deathtime);
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //inputs
        if (isPlayer == true)
        {
            
            gameObject.tag = "Player";
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        //death countdown
    
          
 


    }
    private void FixedUpdate()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed);
        
    }
    
    //Detect if merging into player
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            collision.gameObject.tag = "Player";
            collision.gameObject.GetComponent<EnemyAiFollow>().enabled = false;
            collision.gameObject.GetComponent<shooter>().enabled = true;
            collision.gameObject.GetComponent<playerMovement>().enabled = true;
            collision.gameObject.GetComponent<PlayerShotgun>().enabled = true;
            collision.gameObject.GetComponent<PlayerDasher>().enabled = true;
            collision.gameObject.GetComponent<Playerbeam>().enabled = true;
             //Destroy(this);
        }
    }
    void Deathscene()
    {
        // Death screen
        SceneManager.LoadScene("Scenes/death");
    }
}
