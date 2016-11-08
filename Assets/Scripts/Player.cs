using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour
{
    public GameObject barnObject;
    public Barn barnScript;

    public GameObject bankObject;
    public Bank bankScript;

    public float maxWood;
    public float maxGold;
    public float maxFood;

    public float wood;
    public float gold;
    public float food;

	// Use this for initialization
	void Start ()
    {
        barnObject = GameObject.Find("Barn");
        barnScript = barnObject.GetComponent<Barn>();

        bankObject = GameObject.Find("Bank");
        bankScript = bankObject.GetComponent<Bank>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateResourceCaps();
	
	}

    private void UpdateResourceCaps()
    {
        maxFood = barnScript.currentFoodCap;

        maxGold = bankScript.currentGoldCap;
    }
}
