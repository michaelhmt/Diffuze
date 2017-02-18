using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float PowerUpTime = 3.0f;
    public float currentTime;
    public bool starttime;
    public GameObject Player;
    public PlayerControl PC;
    private bool powerUpActive;
    public float SpeedBoost;
    private bool timesUp = false;
    private float speedCache;


    // Use this for initialization
    void Start()
    {
        speedCache = PC.moveforce;
        starttime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (starttime == true)
        {
            currentTime = PowerUpTime;
            starttime = false;
        }

        Debug.Log("This much time left");
        //Debug.Log (currentTime);

        currentTime = currentTime - 0.01f;

        if (currentTime > 0.0f)
        {
            powerUpActive = false;

        }

        if (currentTime < 0.0f)
        {
            powerUpActive = true;
            timesUp = true;

        }

        if (timesUp == true)
        {
            PC.moveforce = speedCache;
            timesUp = false;
        }



    }

    public void TStart()
    {
        starttime = true;

    }
}