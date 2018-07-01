using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public AdultNeeds adultNeeds;
    public ChildNeeds childNeeds;

    public Image hunger;
    public Image thirst;
    public Image joy;
    public Image rest;

	void Start ()
    {
        
    }
	

	void Update ()
    {
        hunger.fillAmount = adultNeeds.currentFood / adultNeeds.maxFood;
        thirst.fillAmount = adultNeeds.currentDrink / adultNeeds.maxDrink;
        joy.fillAmount = adultNeeds.currentJoy / adultNeeds.maxJoy;
        rest.fillAmount = adultNeeds.currentRest / adultNeeds.maxRest;

        if (Input.GetButtonDown("Jump"))
        {
            Time.timeScale = 5;
            print("Time is 5");
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Time.timeScale = 1;
            print("Time is 1");
        }
    }
}
