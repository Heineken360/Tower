using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyProtectionEnemy : MonoBehaviour
{
    private int n =0;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.tag == "Projectile")
        {
            n++;
        }
        if(n == 2)
        {
            Destroy(gameObject);
            n = 0;
        }
    }
}
