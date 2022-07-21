using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProtectionEnemy : MonoBehaviour
{
    public Transform ProtectionPoint;
    public GameObject protection;
    private float time;
    private float startTime;
    void Start()
    {
        time = Random.Range(15f, 30f);
    }
    void Update()
    {
        
        if(time <= 0)
        {
            
            OnProtection();
        } else
        {
            time -= Time.deltaTime;
        }
        
    }
    public void OnProtection()
    {
        
        Instantiate(protection, ProtectionPoint.position, ProtectionPoint.rotation);
        time = Random.Range(15f, 40f);

    }
}
