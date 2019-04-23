using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedPanel : MonoBehaviour
{
    public GameObject instructionPanel;
    public bool seenInstruction = false;
    public bool conditionRequired;
    public string playerPrefVariableName;
    public string conditionName;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (seenInstruction)
        {
            timer += 1f * Time.deltaTime;

            if (timer >= 5f)
                instructionPanel.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player" && !seenInstruction && 
            PlayerPrefs.GetInt(playerPrefVariableName, 0) == 0)
        {
            if (conditionRequired)
            {
                Debug.Log("Condition is required");
                if (PlayerPrefs.GetInt(conditionName, 0) == 1)
                {
                    instructionPanel.SetActive(true);
                    seenInstruction = true;
                    PlayerPrefs.SetInt(playerPrefVariableName, 1);
                }
            }
            else
            {
                instructionPanel.SetActive(true);
                seenInstruction = true;
                PlayerPrefs.SetInt(playerPrefVariableName, 1);
            }
        }
    }
}
