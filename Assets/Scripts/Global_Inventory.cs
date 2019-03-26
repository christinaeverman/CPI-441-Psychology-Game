using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global_Inventory : MonoBehaviour
{
    public bool showInventory = false;
    public Image[] levelButtons;
    public GameObject[] Level1Text;
    public GameObject[] Level2Text;
    public GameObject[] Level3Text;
    public GameObject[] Level4Text;
    public GameObject[] Level5Text;
    public Image[] Level1Images;
    public Image[] Level2Images;
    public Image[] Level3Images;
    public Image[] Level4Images;
    public Image[] Level5Images;
    public GameObject[] LevelInventories;
    int levelNum = 1;
    int prevLevelNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        //levelButtons = new GameObject[5];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i") && !showInventory)
        {
            Debug.Log("Opening Inventory");
            showInventory = true;
            GetComponent<RectTransform>().localPosition = new Vector3(0, -264, 0);
        }
        else if (Input.GetKeyDown("i") && showInventory)
        {
            Debug.Log("Closing Inventory");
            showInventory = false;
            GetComponent<RectTransform>().localPosition = new Vector3(0, -472, 0);
        }

        // change tab that is currently open
        if (Input.GetKeyDown("1") && showInventory)
        {
            prevLevelNum = levelNum;
            levelNum = 1;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);
        }
        if (Input.GetKeyDown("2") && showInventory)
        {
            prevLevelNum = levelNum;
            levelNum = 2;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);
        }
        if (Input.GetKeyDown("3") && showInventory)
        {
            prevLevelNum = levelNum;
            levelNum = 3;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);
        }
        if (Input.GetKeyDown("4") && showInventory)
        {
            prevLevelNum = levelNum;
            levelNum = 4;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);
        }
        if (Input.GetKeyDown("5") && showInventory)
        {
            prevLevelNum = levelNum;
            levelNum = 5;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);
        }

        if (PlayerPrefs.GetInt("FoundAllLevel1", 0) == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                Level1Text[i].SetActive(true);
                Color color = Level1Images[i].color;
                color.a = 255;
                Level1Images[i].color = color;
            }
        }
        if (PlayerPrefs.GetInt("FoundAllLevel2", 0) == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                Level2Text[i].SetActive(true);
                Color color = Level2Images[i].color;
                color.a = 255;
                Level2Images[i].color = color;
            }
        }
        if (PlayerPrefs.GetInt("FoundAllLevel3", 0) == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                Level3Text[i].SetActive(true);
                Color color = Level3Images[i].color;
                color.a = 255;
                Level3Images[i].color = color;
            }
        }
        if (PlayerPrefs.GetInt("FoundAllLevel4", 0) == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                Level4Text[i].SetActive(true);
                Color color = Level4Images[i].color;
                color.a = 255;
                Level4Images[i].color = color;
            }
        }
        if (PlayerPrefs.GetInt("FoundAllLevel5", 0) == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                Level5Text[i].SetActive(true);
                Color color = Level4Images[i].color;
                color.a = 255;
                Level5Images[i].color = color;
            }
        }

    }
}
