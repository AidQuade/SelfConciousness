using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public float health = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            health = health - 1;

        }

        if (health <= 0)
        {
            if (gameObject.tag == "Enemy")
            {
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Player")
            {
                SceneManager.LoadScene("Scenes/death");
            }
        }


    }
}
