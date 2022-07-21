using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : MonoBehaviour
{
    private float speed;
    public Rigidbody2D rb;
    void Start()
    {
        speed = Random.Range(10f, 20f);
        rb.velocity = transform.right * speed;

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Protection")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == " Projectile")
        {
            Destroy(gameObject);
        }
    }
}
