using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillFood : MonoBehaviour {
    public NPCMove npcMove;
    public AdultNeeds aN;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            aN.currentFood = aN.maxFood;
            npcMove.SetDestination();
        }
    }
}

