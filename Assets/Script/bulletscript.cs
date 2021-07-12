using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{

    public GameObject hitEffect;
    public GameObject hitEffect2;
    public float lifetime = 2f;
    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
            Destroy(gameObject);
        }

        else
        {
            GameObject effect2 = Instantiate(hitEffect2, transform.position, Quaternion.identity);
            Destroy(effect2, 0.4f);
            Destroy(gameObject);
        }
        
        
    }
}
