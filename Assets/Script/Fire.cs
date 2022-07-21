using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
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
            if (Input.touchCount > 0) //Input.GetMouseButton(0)
            {
                Shoot();
                timeShot = startTime;
            }
        } else
        {
            timeShot -= Time.deltaTime;
        }
    }
}

