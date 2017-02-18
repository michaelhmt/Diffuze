using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
    public GameObject Player;
    public PlayerScript Pup;
    public GameObject TimeObject;
    public TimerScript TimerScript;


    void OnTriggerEnter2D(Collider2D myTrigger)
    {

        Debug.Log("it hit the thing");

        if (myTrigger.tag == "Player")
        {
            Pup.Speedboost();
            TimerScript.TStart();
            Destroy(gameObject);
        }
    }

}
