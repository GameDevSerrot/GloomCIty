using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour
{
    public Player player;

    #region UIText
    public Text wood;

    public Text meat;

    public Text gold;
    #endregion

    #region Menus
    private GameObject buildMenu;
    public GameObject barracksMenu;
    public GameObject barnMenu;
    public GameObject bankMenu;
    #endregion

    #region Prefabs
    public GameObject housePrefab;
    public GameObject barnPrefab;
    public GameObject minePrefab;
    public GameObject lumberyardPrefab;
    public GameObject farmPrefab;
    public GameObject barracksPrefab;
    #endregion

    #region ActiveObjects
    public GameObject buildingToPlace;

    public GameObject activeBarracks;
    public Barracks activeBarracksScript;

    public GameObject activeBarn;
    public Barn activeBarnScript;
    public Text activeBarnInfo;

    public GameObject activeBank;
    public Bank activeBankScript;
    public Text activeBankInfo;

    #endregion
    public bool placingBuilding;

    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<Player>();

        wood = GameObject.Find("WoodText").GetComponent<Text>();
        meat = GameObject.Find("MeatText").GetComponent<Text>();
        gold = GameObject.Find("GoldText").GetComponent<Text>();

        buildMenu = GameObject.Find("BuildMenu");
        buildMenu.SetActive(false);

        barracksMenu = GameObject.Find("BarracksMenu");
        barracksMenu.SetActive(false);

        barnMenu = GameObject.Find("BarnMenu");
        barnMenu.SetActive(false);

        bankMenu = GameObject.Find("BankMenu");
        bankMenu.SetActive(false);  
    }
	
	// Update is called once per frame
	void Update ()
    {
        UpdatePlayerResources();
        DisplayBarnInfo();
        DisplayBankInfo();

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 1000))
            {
                if (hit.collider.CompareTag("Barracks"))
                {
                    activeBarracks = hit.collider.gameObject;
                    activeBarracksScript = activeBarracks.GetComponent<Barracks>();

                    barracksMenu.SetActive(true);
                }
                else if (hit.collider.CompareTag("Barn"))
                {
                    activeBarn = hit.collider.gameObject;
                    activeBarnScript = activeBarn.GetComponent<Barn>();
                    barnMenu.SetActive(true);
                }
                else if (hit.collider.CompareTag("Bank"))
                {
                    activeBank = hit.collider.gameObject;
                    activeBankScript = activeBank.GetComponent<Bank>();
                    bankMenu.SetActive(true);
                }
            }
        }

        //if (barracksMenu.activeSelf)
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        if (Physics.Raycast(ray, out hit, 1000))
        //        {
        //            if (hit.collider.CompareTag("Ground"))
        //            {
        //                barracksMenu.SetActive(false);
        //            }
        //        }
        //    }

        //}

        if (placingBuilding)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out hit, 1000))
                {
                    if (hit.collider.CompareTag("Ground"))
                    {
                        Instantiate(buildingToPlace, hit.point, Quaternion.Euler(0, 180, 0));
                        placingBuilding = false;
                    }
                }
            }
        }
    }

    private void UpdatePlayerResources()
    {
        wood.text = player.wood.ToString() + " / " + player.maxWood;
        meat.text = player.food.ToString() + " / " + player.maxFood;
        gold.text = player.gold.ToString() + " / " + player.maxGold;
    }

    private void DisplayBarnInfo()
    {
        if (barnMenu.activeSelf)
        {
            activeBarnInfo.text = "Barn " + activeBarnScript.state.ToString() + "\n\n\n" +
                                    "Food Capacity: " + activeBarnScript.currentFoodCap;
        }
    }
    private void DisplayBankInfo()
    {
        if (bankMenu.activeSelf)
        {
            activeBankInfo.text = "Bank " + activeBankScript.state.ToString() + "\n\n\n" +
                                    "Gold Capacity: " + activeBankScript.currentGoldCap;
        }
    }

    public void BuildButton()
    {
        if (buildMenu.activeSelf)
        {
            buildMenu.SetActive(false);
        }
        else if (!buildMenu.activeSelf)
        {
            buildMenu.SetActive(true);
        }
    }

    public void BuildBarracks()
    {
        buildMenu.SetActive(false);

        buildingToPlace = barracksPrefab;
        placingBuilding = true;
    }

    public void BuildHouse()
    {
        buildMenu.SetActive(false);

        buildingToPlace = housePrefab;
        placingBuilding = true;
    }

    public void BuildFarm()
    {
        buildMenu.SetActive(false);

        buildingToPlace = farmPrefab;
        placingBuilding = true;
    }

    public void BuildBarn()
    {
        buildMenu.SetActive(false);

        buildingToPlace = barnPrefab;
        placingBuilding = true;
    }

    public void BuildMine()
    {
        buildMenu.SetActive(false);

        buildingToPlace = minePrefab;
        placingBuilding = true;
    }

    public void BuildLumberyard()
    {
        buildMenu.SetActive(false);

        buildingToPlace = lumberyardPrefab;
        placingBuilding = true;
    }

    public void TrainArcher()
    {
        activeBarracksScript.TrainArcher();
        barracksMenu.SetActive(false);
    }

    public void TrainKinght()
    {
        activeBarracksScript.TrainKnight();
        barracksMenu.SetActive(false);
    }

    public void CloseBarracksMenu()
    {
        barracksMenu.SetActive(false);
    }
    public void CloseBarnMenu()
    {
        barnMenu.SetActive(false);
    }

    public void CloseBankMenu()
    {
        bankMenu.SetActive(false);
    }

    public void UpgradeActiveBarn()
    {
        activeBarnScript.UpgradeBarn();
    }
    public void UpgradeActiveBank()
    {
        activeBankScript.UpgradeBank();
    }
}