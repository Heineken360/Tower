using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Protection : MonoBehaviour
{
    public Transform ProtectionPoint;
    public GameObject protection;
    public Button protectionButton;
    public GameObject protectionTimer;
    private float timeButton;
    private float startButton = 15f;
    private int n;
    private float timeStart = 15f;
    public Text Timer;
    void Start()
    {
        Timer.text = timeStart.ToString();
    }
    void Update()
    {
        if(timeButton <= 0)
        {
            protectionButton.interactable = true;
            protectionTimer.SetActive(false);
            timeStart = 15f;
        } else
        {
            timeButton -= Time.deltaTime;
            timeStart -= Time.deltaTime;
            Timer.text = "0:" + Mathf.Round(timeStart).ToString();
        }
        
        
    }
    public void OnProtection()
    {
        Instantiate(protection, ProtectionPoint.position, ProtectionPoint.rotation);
        protectionButton.interactable = false;
        protectionTimer.SetActive(true);
        timeButton = startButton;
        n = 0;
        
    }
   
}
