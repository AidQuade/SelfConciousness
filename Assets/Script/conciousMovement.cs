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
    public float survivalTime = 5f;
    private float timeOut;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        timeOut = survivalTime;
    }

    private void Awake()
    {
        timeOut = 5f;
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
        /*if (timeOut <= 0)
        {
            //Destroy(gameObject);
           // SceneManager.LoadScene("death");
        }
        else
        {
            timeOut -= Time.deltaTime;
        }*/

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
            
        }
    }
}
