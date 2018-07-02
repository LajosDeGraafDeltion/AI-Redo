using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildNeeds : BaseNeeds {

    void Start()
    {
        UseThis();
    }


    void Update()
    {

    }

    public IEnumerator DecreaseChildStats()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1.7f));
        currentDrink -= Random.Range(0.2f, 1.5f);
        currentFood -= Random.Range(0.1f, 2.5f);
        currentJoy -= Random.Range(0.1f, 3.5f);
        currentRest -= Random.Range(0.5f, 5.0f);
        StartCoroutine(DecreaseChildStats());
    }

    public override void UseThis()
    {
        currentDrink = maxDrink;
        currentFood = maxFood;
        currentJoy = maxJoy;
        currentRest = maxRest;
    }
}
