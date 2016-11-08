using UnityEngine;
using System.Collections;

public class Bank : MonoBehaviour 
{
    public float currentGoldCap;
    public float goldCapLevelOne;
    public float goldCapLevelTwo;

    public float goldCapLevelThree;

    public float upgradeCost;

    public enum BankState
    {
        Level1,

        Level2,

        Level3
    }

    public BankState state = BankState.Level1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case BankState.Level1:
                currentGoldCap = goldCapLevelOne;
                break;
            case BankState.Level2:
                currentGoldCap = goldCapLevelTwo;
                break;
            case BankState.Level3:
                currentGoldCap = goldCapLevelThree;
                break;
        }
    }

    public void UpgradeBank()
    {
        if (state == BankState.Level1)
        {
            state = BankState.Level2;
        }
        else if (state == BankState.Level2)
        {
            state = BankState.Level3;
        }
    }
}
