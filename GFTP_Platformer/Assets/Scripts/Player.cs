using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int score = 0;
    private bool canBeDamaged = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    // Increases score by amount
    // returns current score
    public int incrementScore(int amount)
    {
        return score += amount;
    }

    // Starts powerup effect for time amount of time
    public void powerup(float time)
    {
        while(time > 0)
        {
            canBeDamaged = false;
            time -= Time.deltaTime;
        }
        canBeDamaged = true;
    }

    // kills the player
    public void die()
    {

    }
}
