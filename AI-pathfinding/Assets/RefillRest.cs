using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillRest : MonoBehaviour {
    public NPCMove npcMove;
    public AdultNeeds aN;


    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            aN.currentRest = aN.maxRest;
            npcMove.SetDestination();
        }
    }
}
