using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed;
    
    void Start()
    {
        speed = Random.Range(15f, 20f);
        rb.velocity = transform.right * speed;

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ProjectileEnemy")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "ProtectionEnemy")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
