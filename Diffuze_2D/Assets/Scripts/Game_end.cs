using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_end : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "Player") {
			Application.LoadLevel (0);
			Debug.Log ("I'm so turned on right now you don't even know!");

		}

       }

    }

