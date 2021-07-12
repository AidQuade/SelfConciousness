using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotgun : MonoBehaviour
{
 //public Animator animator;
    public bool moving = false;
    public float moveSpeed = 0.3f;
    public timeManager TimeManager;
    public GameObject conciousness;
    private Rigidbody2D rb;
    private bool isPlayer = true;
    private Vector2 movement;
    private Vector3 mousePos;
    
    private Camera cam;
    
    private Rigidbody2D rd;
    void Start()
    {
        rd = this.GetComponent<Rigidbody2D> ();
        cam = Camera.main;
     
    }
    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Player")
        {
            isPlayer = true;
            gameObject.GetComponent<shooter>().enabled = true;
        }
        if (gameObject.tag == "Enemy")
        {
            isPlayer = false;
            gameObject.GetComponent<shooter>().enabled = false;
        }
        //inputs
        if (isPlayer == true)
        {
            rotateCamera();
            gameObject.tag = "Player";
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }

        /*if (movement.x > 0 || movement.y > 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }*/
        
        
        if (Input.GetKeyDown(KeyCode.LeftShift) && gameObject.tag == "Player")
        {
            TimeManager.SlowMotion();
            Instantiate(conciousness, transform.position, Quaternion.identity);
            gameObject.tag = "non";
            GetComponent<shooter>().enabled = false; 
            isPlayer = false;
            GetComponent<PlayerShotgun>().enabled = false;
            Destroy(this);
           
        }
    }
    private void FixedUpdate()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed);
        
    }
    void rotateCamera()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Input.mousePosition.z));
        rd.transform.eulerAngles = new Vector3(0, 0,
            Mathf.Atan2((mousePos.y - transform.position.y), (mousePos.x - transform.position.x)) * Mathf.Rad2Deg);
        
    }
}
