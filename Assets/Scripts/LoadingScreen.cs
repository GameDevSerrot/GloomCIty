using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingScreen : MonoBehaviour
{

    public float loadTime = 5.0f;          //the time it takes the loading bar to fill
    public float timer = 0.0f;             //used to keep track of time

    Image loadBarProgress;          //used to simulate a loading bar
	// Use this for initialization
	void Start ()
    {
        GameObject lb = GameObject.Find("LoadBarProgress");
        loadBarProgress = lb.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        loadBarProgress.fillAmount = timer / loadTime;

        if (timer > loadTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	
	}
}
