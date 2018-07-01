using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillWater : MonoBehaviour {
    public NPCMove npcMove;
    public AdultNeeds aN;


    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            aN.currentDrink = aN.maxDrink;
            npcMove.SetDestination();
        }ai
    }
}

