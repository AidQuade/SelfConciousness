using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiFollow : MonoBehaviour
{
    public float speed;
    public float viewDistance;
    public float stoppingDistance;
    public float retreatDistance;
    public GameObject bullet;
    public Transform bulletPoint;
    private Transform player;
    private Vector3 startingPos;
    public float health = 10;
    private float timeBtwShot;
    private Rigidbody2D rb;
    public float bulletForce = 30f;
    public float startTimeShots;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D> ();
        startingPos = transform.position;
        timeBtwShot = startTimeShots;
    }

    private Vector3 GetRoamPos()
    {
        return startingPos + GetRandomDir() * Random.Range(10f,70f);
    }

    // Update is called once per frame
    void Update()
    {
        //follow, stop, retreat
        player = GameObject.FindGameObjectWithTag("Player").transform;
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance && Vector2.Distance(transform.position, player.position) > viewDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) > stoppingDistance && Vector2.Distance(transform.position, player.position) < viewDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
          //countdown between shots
        if (timeBtwShot <= 0 && Vector2.Distance(transform.position, player.position) < viewDistance)
        {
            Shoot();
            timeBtwShot = startTimeShots;
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
        }
        
        rb.transform.eulerAngles = new Vector3(0, 0,
            Mathf.Atan2((player.position.y - transform.position.y), (player.position.x - transform.position.x)) * Mathf.Rad2Deg);


    }

    public static Vector3 GetRandomDir()
    {
        return new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;
    }
    void Shoot()
    {
        GameObject firedbullet = Instantiate(bullet, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = firedbullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            health = health - 1;
                
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
