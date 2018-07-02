using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillStat : MonoBehaviour {

    public NPCMove npcMove;
    public AdultNeeds aN;
	

	void Update ()
    {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            aN.currentDrink = aN.maxDrink;
            npcMove.SetDestination();
        }

        if (other.gameObject.tag == "Player")
        {
            aN.currentFood = aN.maxFood;
            npcMove.SetDestination();
        }

        if (other.gameObject.tag == "Player")
        {
            aN.currentJoy = aN.maxJoy;
            npcMove.SetDestination();
        }
        if (other.gameObject.tag == "Player")
        {
            aN.currentRest = aN.maxRest;
            npcMove.SetDestination();
        }
    }
}
