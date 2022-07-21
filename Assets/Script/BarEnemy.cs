using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarEnemy : MonoBehaviour
{
    public Image barEnemy;
    public float fill;


    void Start()
    {
        fill = 1f;

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Projectile")
        {
            fill -= 0.1f;
            barEnemy.fillAmount = fill;
            if (fill <= 0)
            {
                Debug.Log("You Win!");
            }
        }
    }
}
