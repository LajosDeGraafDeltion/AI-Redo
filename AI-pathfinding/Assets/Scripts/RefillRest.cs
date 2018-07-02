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
        if (other.gameObject.tag == "Adult")
        {
            aN.currentRest = aN.maxRest;
            print("Get this");
            npcMove.SetDestination();
        }
    }
}
