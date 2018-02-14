using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public PickupType type = PickupType.coin;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Player"))
        {
            switch (type)
            {
                case PickupType.coin:
                    collision.GetComponent<Player>().incrementScore(1);
                    break;
                case PickupType.powerup:
                    collision.GetComponent<Player>().powerup(5f);
                    break;
            }
        }
    }

    public enum PickupType { coin, powerup };

}
