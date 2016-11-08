using UnityEngine;
using System.Collections;

public class Barn : MonoBehaviour
{
    public float currentFoodCap;
    public float foodCapLevelOne;
    public float foodCapLevelTwo;

    public float foodCapLevelThree;

    public float upgradeCost;

    public enum BarnState
    {
        Level1,

        Level2,

        Level3
    }

    public BarnState state = BarnState.Level1;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    { 
        switch(state)
        {
            case BarnState.Level1:
                currentFoodCap = foodCapLevelOne;
                break;
            case BarnState.Level2:
                currentFoodCap = foodCapLevelTwo;
                break;
            case BarnState.Level3:
                currentFoodCap = foodCapLevelThree;
                break;
        }
    }

    public void UpgradeBarn()
    {
        if (state == BarnState.Level1)
        {
            state = BarnState.Level2;
        }
        else if (state == BarnState.Level2)
        {
            state = BarnState.Level3;
        }
    }
}
