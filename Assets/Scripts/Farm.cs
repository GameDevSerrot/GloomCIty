using UnityEngine;
using System.Collections;

public class Farm : MonoBehaviour
{
    public Player player;
    public GameObject farmFullMarker;

    public float food;
    public float maxFood;
    public float gatherRate;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Player>();
        farmFullMarker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseFood();
        CollectFood();
    }

    private void IncreaseFood()
    {
        if (food < maxFood)
        {
            food += gatherRate * Time.deltaTime;
        }
        else if (food >= maxFood)
        {
            farmFullMarker.SetActive(true);
        }
    }

    private void CollectFood()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000))
            {
                if (hit.collider.gameObject.GetInstanceID() == gameObject.GetInstanceID())
                {
                    player.food += food;
                    food = 0;
                    farmFullMarker.SetActive(false);
                }
            }
        }
    }
}
