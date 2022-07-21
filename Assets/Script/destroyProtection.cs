using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyProtection : MonoBehaviour
{
    private int n;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ProjectileEnemy")
        {
            n++;
        }
        if (n == 2)
        {
            Destroy(gameObject);
            n = 0;
        }
    }
}
