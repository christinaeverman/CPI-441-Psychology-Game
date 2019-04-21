using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Clue_Object Clue1;
    public Clue_Object Clue2;
    public Clue_Object Clue3;
    public Clue_Object Clue4;
    public GameObject Clue1_Text;
    public GameObject Clue2_Text;
    public GameObject Clue3_Text;
    public GameObject Clue4_Text;
    public Image Clue1_Image;
    public Image Clue2_Image;
    public Image Clue3_Image;
    public Image Clue4_Image;
    public static bool FoundAll = false;

    // Start is called before the first frame update
    void Start()
    {
        FoundAll = false;
        PlayerPrefs.SetInt("menuOpened", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Clue1.Found)
        {
            Clue1_Text.SetActive(true);
            Color color = Clue1_Image.color;
            color.a = 255;
            Clue1_Image.color = color;
        }
        if (Clue2.Found)
        {
            Clue2_Text.SetActive(true);
            Color color = Clue2_Image.color;
            color.a = 255;
            Clue2_Image.color = color;
        }
        if (Clue3.Found)
        {
            Clue3_Text.SetActive(true);
            Color color = Clue3_Image.color;
            color.a = 255;
            Clue3_Image.color = color;
        }
        if (Clue4.Found)
        {
            Clue4_Text.SetActive(true);
            Color color = Clue4_Image.color;
            color.a = 255;
            Clue4_Image.color = color;
        }

        if (Clue1.Found && Clue2.Found && Clue3.Found && Clue4.Found)
        {
            FoundAll = true;
        }
    }

    public void ShowObject(GameObject obj)
    {
        obj.gameObject.SetActive(true);
    }

    public void HideObject(GameObject obj)
    {
        obj.gameObject.SetActive(false);
    }

    public void LoadMainMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
