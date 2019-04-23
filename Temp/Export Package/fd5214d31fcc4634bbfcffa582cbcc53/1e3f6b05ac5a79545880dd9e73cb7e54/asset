using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clues_Found_Level3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("FoundAllLevel3", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelManager.FoundAll)
            PlayerPrefs.SetInt("FoundAllLevel3", 1);
    }
}
