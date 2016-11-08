using UnityEngine;
using System.Collections;

public class Barracks : MonoBehaviour
{
    public float timer;
    public float trainingTime;
    public GameObject knight;
    public float knightTrainTime;
    public GameObject archer;
    public float archerTrainTIme;

    public GameObject unitToTrain;

    public GameObject spawnPoint;

    public GameObject barracksMenu;

    //public UI ui;

    public enum BarracksState
    {
        Idle,

        Training
    }

    public BarracksState state = BarracksState.Idle;

	// Use this for initialization
	void Start ()
    {
       // ui = FindObjectOfType<UI>();
       // barracksMenu = ui.barracksMenu;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    switch(state)
        {
            case BarracksState.Idle:
                break;
            case BarracksState.Training:
                Training();
                break;
        }
	}

    public void Training()
    {
        timer += Time.deltaTime;

        if (timer > trainingTime)
        {
            Instantiate(unitToTrain, spawnPoint.transform.position, Quaternion.identity);

            timer = 0;

            state = BarracksState.Idle;
        }
    }

    public void TrainArcher()
    {
        unitToTrain = archer;
        trainingTime = archerTrainTIme;
        state = BarracksState.Training;
    }

    public void TrainKnight()
    {
        unitToTrain = knight;
        trainingTime = knightTrainTime;
        state = BarracksState.Training;
    }
}
