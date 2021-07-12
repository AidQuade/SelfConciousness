using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public Transform bulletPoint;
    public Transform bulletPoint2;
    public GameObject bulletPrefab;
    public float gunType = 1f;
    public float bulletForce = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (gunType == 1){
            GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
    }
        else if (gunType == 2){
            GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            GameObject bullet2 = Instantiate(bulletPrefab, bulletPoint2.position, bulletPoint2.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
            Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
            rb2.AddForce(bulletPoint2.up * bulletForce, ForceMode2D.Impulse);
        }
        else if (gunType == 3)
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
        }
}
}


