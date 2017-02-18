using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public GameObject Player;
    public PlayerControl PC;
    public GameObject TimeObject;
    public TimerScript TimerScript;
    private bool powerUpActive;
    public float SpeedBoost;
    private bool timesUp = false;

    public void Speedboost()
    {
        PC.moveforce = SpeedBoost;
        powerUpActive = true;
        TimerScript.TStart();
        Debug.Log("I'm running");
    }
}