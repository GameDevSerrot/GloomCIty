using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour
{
    public Player player;
    public GameObject mineFullMarker;

    public float gold;
    public float maxGold;
    public float gatherRate;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Player>();
        mineFullMarker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseGold();
        CollectGold();
    }

    private void IncreaseGold()
    {
        if (gold < maxGold)
        {
            gold += gatherRate * Time.deltaTime;
        }
        else if (gold >= maxGold)
        {
            mineFullMarker.SetActive(true);
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
                    player.gold += gold;
                    gold = 0;
                    mineFullMarker.SetActive(false);
                }
            }
        }
    }
}
