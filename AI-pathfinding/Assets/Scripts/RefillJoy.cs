using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillJoy : MonoBehaviour {

    public NPCMove npcMove;
    public AdultNeeds aN;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Adult")
        {
            aN.currentJoy = aN.maxJoy;
            npcMove.SetDestination();
        }
    }
}
