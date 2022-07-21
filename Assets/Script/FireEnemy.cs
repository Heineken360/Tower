using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    private float timeShot;
    public float startTime;
    public void Shoot()
    {

        Instantiate(bullet, firePoint.position, firePoint.rotation);

    }
    void Update()
    {
        

        if (timeShot <= 0)
        {
            
                Shoot();
                timeShot = startTime;
            
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
}



