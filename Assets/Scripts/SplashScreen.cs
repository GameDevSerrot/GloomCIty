using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour
{
    private float loadScenetime = 5;     //the time it takes for the splash to switch to main menu
    public float timer;                  //keeps track of time
	
	// Update is called once per frame
	void Update ()
    {
        if (timer > loadScenetime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        timer += Time.deltaTime;
    }
}
