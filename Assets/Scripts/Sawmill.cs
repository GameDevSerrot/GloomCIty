using UnityEngine;
using System.Collections;

public class Sawmill : MonoBehaviour
{
    public Player player;
    public GameObject sawmillFullMarker;

    public float wood;
    public float maxWood;
    public float gatherRate;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Player>();
        sawmillFullMarker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseGold();
        CollectGold();
    }

    private void IncreaseGold()
    {
        if (wood < maxWood)
        {
            wood += gatherRate * Time.deltaTime;
        }
        else if (wood >= maxWood)
        {
            sawmillFullMarker.SetActive(true);
        }
    }

    private void CollectGold()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000))
            {
                if (hit.collider.gameObject.GetInstanceID() == gameObject.GetInstanceID())
                {
                    player.gold += wood;
                    wood = 0;
                    sawmillFullMarker.SetActive(false);
                }
            }
        }
    }
}
