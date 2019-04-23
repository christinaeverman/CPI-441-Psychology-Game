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
    public GameObject[] Level1Descriptions;
    public GameObject[] Level2Descriptions;
    public GameObject[] Level3Descriptions;
    public GameObject[] Level4Descriptions;
    public GameObject[] Level5Descriptions;
    public GameObject[] LevelInventories;
    public bool activateDescriptions;
    public bool descriptionActive = false;
    int levelNum = 1;
    int prevLevelNum = 1;
    private IEnumerator waitCoroutine;

    // Audio
    AudioSource source;
    public AudioClip inventorySound;
    public AudioClip tabSound;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("FoundAllLevel1", 0) == 1)
            activateDescriptions = true;
        else
            activateDescriptions = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i") && !showInventory && PlayerPrefs.GetInt("menuOpened", 0) == 0)
        {
            source.PlayOneShot(inventorySound, 0.4f);
            showInventory = true;
            GetComponent<RectTransform>().localPosition = new Vector3(0, -264, 0);
        }
        else if (Input.GetKeyDown("i") && showInventory && PlayerPrefs.GetInt("menuOpened", 0) == 0)
        {
            source.PlayOneShot(inventorySound, 0.4f);
            showInventory = false;
            GetComponent<RectTransform>().localPosition = new Vector3(0, -472, 0);
        }

        // change tab that is currently open
        if (Input.GetKeyDown("1") && showInventory)
        {
            source.PlayOneShot(tabSound, 0.3f);
            prevLevelNum = levelNum;
            levelNum = 1;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);

            if (PlayerPrefs.GetInt("FoundAllLevel1", 0) == 1)
                activateDescriptions = true;
            else
                activateDescriptions = false;

            for (int i = 0; i < 4; i++)
            {
                Level2Descriptions[i].SetActive(false);
                Level3Descriptions[i].SetActive(false);
                Level4Descriptions[i].SetActive(false);
                Level5Descriptions[i].SetActive(false);
                float alpha = Level2Images[i].color.a;
                Level2Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level3Images[i].color.a;
                Level3Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level4Images[i].color.a;
                Level4Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level5Images[i].color.a;
                Level5Images[i].color = new Color(1f, 1f, 1f, alpha);
            }

            descriptionActive = false;
        }
        if (Input.GetKeyDown("2") && showInventory)
        {
            source.PlayOneShot(tabSound, 0.3f);
            prevLevelNum = levelNum;
            levelNum = 2;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);

            if (PlayerPrefs.GetInt("FoundAllLevel2", 0) == 1)
                activateDescriptions = true;
            else
                activateDescriptions = false;

            for (int i = 0; i < 4; i++)
            {
                Level1Descriptions[i].SetActive(false);
                Level3Descriptions[i].SetActive(false);
                Level4Descriptions[i].SetActive(false);
                Level5Descriptions[i].SetActive(false);
                float alpha = Level1Images[i].color.a;
                Level1Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level3Images[i].color.a;
                Level3Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level4Images[i].color.a;
                Level4Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level5Images[i].color.a;
                Level5Images[i].color = new Color(1f, 1f, 1f, alpha);
            }

            descriptionActive = false;
        }
        if (Input.GetKeyDown("3") && showInventory)
        {
            source.PlayOneShot(tabSound, 0.3f);
            prevLevelNum = levelNum;
            levelNum = 3;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);

            if (PlayerPrefs.GetInt("FoundAllLevel3", 0) == 1)
                activateDescriptions = true;
            else
                activateDescriptions = false;

            for (int i = 0; i < 4; i++)
            {
                Level2Descriptions[i].SetActive(false);
                Level1Descriptions[i].SetActive(false);
                Level4Descriptions[i].SetActive(false);
                Level5Descriptions[i].SetActive(false);
                float alpha = Level2Images[i].color.a;
                Level2Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level1Images[i].color.a;
                Level1Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level4Images[i].color.a;
                Level4Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level5Images[i].color.a;
                Level5Images[i].color = new Color(1f, 1f, 1f, alpha);
            }

            descriptionActive = false;
        }
        if (Input.GetKeyDown("4") && showInventory)
        {
            source.PlayOneShot(tabSound, 0.3f);
            prevLevelNum = levelNum;
            levelNum = 4;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);

            if (PlayerPrefs.GetInt("FoundAllLevel4", 0) == 1)
                activateDescriptions = true;
            else
                activateDescriptions = false;

            for (int i = 0; i < 4; i++)
            {
                Level2Descriptions[i].SetActive(false);
                Level3Descriptions[i].SetActive(false);
                Level1Descriptions[i].SetActive(false);
                Level5Descriptions[i].SetActive(false);
                float alpha = Level2Images[i].color.a;
                Level2Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level3Images[i].color.a;
                Level3Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level1Images[i].color.a;
                Level1Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level5Images[i].color.a;
                Level5Images[i].color = new Color(1f, 1f, 1f, alpha);
            }

            descriptionActive = false;
        }
        if (Input.GetKeyDown("5") && showInventory)
        {
            source.PlayOneShot(tabSound, 0.3f);
            prevLevelNum = levelNum;
            levelNum = 5;
            levelButtons[prevLevelNum - 1].GetComponent<Image>().color = new Color(0.3867f, 0.0091f, 0.0091f, 1f);
            levelButtons[levelNum - 1].GetComponent<Image>().color = new Color(0.2169f, 0.0112f, 0.0112f, 1);
            LevelInventories[prevLevelNum - 1].SetActive(false);
            LevelInventories[levelNum - 1].SetActive(true);

            if (PlayerPrefs.GetInt("FoundAllLevel5", 0) == 1)
                activateDescriptions = true;
            else
                activateDescriptions = false;
            for (int i = 0; i < 4; i++)
            {
                Level2Descriptions[i].SetActive(false);
                Level3Descriptions[i].SetActive(false);
                Level4Descriptions[i].SetActive(false);
                Level1Descriptions[i].SetActive(false);
                float alpha = Level2Images[i].color.a;
                Level2Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level3Images[i].color.a;
                Level3Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level4Images[i].color.a;
                Level4Images[i].color = new Color(1f, 1f, 1f, alpha);
                alpha = Level1Images[i].color.a;
                Level1Images[i].color = new Color(1f, 1f, 1f, alpha);
            }

            descriptionActive = false;
        }
        if (Input.GetKeyDown("6") && activateDescriptions && !descriptionActive)
        {
            switch(levelNum)
            {
                case 1:
                    Level1Descriptions[0].SetActive(true);
                    Level1Images[0].color = Color.yellow;
                    waitCoroutine = Wait(Level1Descriptions[0], Level1Images[0]);
                    break;
                case 2:
                    Level2Descriptions[0].SetActive(true);
                    Level2Images[0].color = Color.yellow;
                    waitCoroutine = Wait(Level2Descriptions[0], Level2Images[0]);
                    break;
                case 3:
                    Level3Descriptions[0].SetActive(true);
                    Level3Images[0].color = Color.yellow;
                    waitCoroutine = Wait(Level3Descriptions[0], Level3Images[0]);
                    break;
                case 4:
                    Level4Descriptions[0].SetActive(true);
                    Level4Images[0].color = Color.yellow;
                    waitCoroutine = Wait(Level4Descriptions[0], Level4Images[0]);
                    break;
                case 5:
                    Level5Descriptions[0].SetActive(true);
                    Level5Images[0].color = Color.yellow;
                    waitCoroutine = Wait(Level5Descriptions[0], Level5Images[0]);
                    break;
                default:
                    break;
            }

            descriptionActive = true;
            StartCoroutine(waitCoroutine);
        }
        if (Input.GetKeyDown("7") && activateDescriptions && !descriptionActive)
        {
            switch (levelNum)
            {
                case 1:
                    Level1Descriptions[1].SetActive(true);
                    Level1Images[1].color = Color.yellow;
                    waitCoroutine = Wait(Level1Descriptions[1], Level1Images[1]);
                    break;
                case 2:
                    Level2Descriptions[1].SetActive(true);
                    Level2Images[1].color = Color.yellow;
                    waitCoroutine = Wait(Level2Descriptions[1], Level2Images[1]);
                    break;
                case 3:
                    Level3Descriptions[1].SetActive(true);
                    Level3Images[1].color = Color.yellow;
                    waitCoroutine = Wait(Level3Descriptions[1], Level3Images[1]);
                    break;
                case 4:
                    Level4Descriptions[1].SetActive(true);
                    Level4Images[1].color = Color.yellow;
                    waitCoroutine = Wait(Level4Descriptions[1], Level4Images[1]);
                    break;
                case 5:
                    Level5Descriptions[1].SetActive(true);
                    Level5Images[1].color = Color.yellow;
                    waitCoroutine = Wait(Level5Descriptions[1], Level5Images[1]);
                    break;
                default:
                    break;
            }

            descriptionActive = true;
            StartCoroutine(waitCoroutine);
        }
        if (Input.GetKeyDown("8") && activateDescriptions && !descriptionActive)
        {
            switch (levelNum)
            {
                case 1:
                    Level1Descriptions[2].SetActive(true);
                    Level1Images[2].color = Color.yellow;
                    waitCoroutine = Wait(Level1Descriptions[2], Level1Images[2]);
                    break;
                case 2:
                    Level2Descriptions[2].SetActive(true);
                    Level2Images[2].color = Color.yellow;
                    waitCoroutine = Wait(Level2Descriptions[2], Level2Images[2]);
                    break;
                case 3:
                    Level3Descriptions[2].SetActive(true);
                    Level3Images[2].color = Color.yellow;
                    waitCoroutine = Wait(Level3Descriptions[2], Level3Images[2]);
                    break;
                case 4:
                    Level4Descriptions[2].SetActive(true);
                    Level4Images[2].color = Color.yellow;
                    waitCoroutine = Wait(Level4Descriptions[2], Level4Images[2]);
                    break;
                case 5:
                    Level5Descriptions[2].SetActive(true);
                    Level5Images[2].color = Color.yellow;
                    waitCoroutine = Wait(Level5Descriptions[2], Level5Images[2]);
                    break;
                default:
                    break;
            }

            descriptionActive = true;
            StartCoroutine(waitCoroutine);
        }
        if (Input.GetKeyDown("9") && activateDescriptions && !descriptionActive)
        {
            switch (levelNum)
            {
                case 1:
                    Level1Descriptions[3].SetActive(true);
                    Level1Images[3].color = Color.yellow;
                    waitCoroutine = Wait(Level1Descriptions[3], Level1Images[3]);
                    break;
                case 2:
                    Level2Descriptions[3].SetActive(true);
                    Level2Images[3].color = Color.yellow;
                    waitCoroutine = Wait(Level2Descriptions[3], Level2Images[3]);
                    break;
                case 3:
                    Level3Descriptions[3].SetActive(true);
                    Level3Images[3].color = Color.yellow;
                    waitCoroutine = Wait(Level3Descriptions[3], Level3Images[3]);
                    break;
                case 4:
                    Level4Descriptions[3].SetActive(true);
                    Level4Images[3].color = Color.yellow;
                    waitCoroutine = Wait(Level4Descriptions[3], Level4Images[3]);
                    break;
                case 5:
                    Level5Descriptions[3].SetActive(true);
                    Level5Images[3].color = Color.yellow;
                    waitCoroutine = Wait(Level5Descriptions[3], Level5Images[3]);
                    break;
                default:
                    break;
            }

            descriptionActive = true;
            StartCoroutine(waitCoroutine);
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
                Color color = Level5Images[i].color;
                color.a = 255;
                Level5Images[i].color = color;
            }
        }

    }

    IEnumerator Wait(GameObject descriptionPanel, Image clueSprite)
    {
        yield return new WaitForSeconds(3f);
        descriptionPanel.SetActive(false);
        clueSprite.color = Color.white;
        descriptionActive = false;
    }
}
