using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultNeeds : BaseNeeds {


	void Start ()
    {
        UseThis();
    }
	

	void Update ()
    {
        DecreaseStats();
	}

    public IEnumerator DecreaseStats()
    {
        yield return new WaitForSeconds(Random.Range(0.4f, 1.5f));
        currentDrink -= Random.Range(0.2f, 5f);
        currentFood -= Random.Range(0.1f, 5f);
        currentJoy -= Random.Range(0.1f, 6.5f);
        currentRest -= Random.Range(0.5f, 7.0f);
        StartCoroutine(DecreaseStats());
    }

    public override void UseThis()
    {
        currentDrink = maxDrink;
        currentFood = maxFood;
        currentJoy = maxJoy;
        currentRest = maxRest;
        StartCoroutine(DecreaseStats());
    }
}
