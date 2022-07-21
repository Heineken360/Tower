using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarPlayer : MonoBehaviour
{
    public Image barPlayer;
    public float fill;

    void Start()
    {
        fill = 1f;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ProjectileEnemy")
        {
            fill -= 0.1f;
            barPlayer.fillAmount = fill;
            if (fill <= 0)
            {
                Debug.Log("You lose!");
            }
        }

    }
}
