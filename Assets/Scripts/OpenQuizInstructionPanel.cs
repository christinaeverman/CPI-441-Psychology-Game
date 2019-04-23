using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.KeyCode;

public class OpenQuizInstructionPanel : MonoBehaviour
{
    public bool seenInstruction = false;
    public bool pressedKey = false;
    public GameObject instructionPanel;
    public KeyCode userKey;
    public KeyCode userKey2;
    public string playerPrefVariableName;
    public string conditionName;
    public string conditionName2;
    public string conditionName3;
    public string conditionName4;
    public string conditionName5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (seenInstruction && (Input.GetKey(userKey) || Input.GetKey(userKey2)))
            instructionPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player" && !seenInstruction &&
            PlayerPrefs.GetInt(playerPrefVariableName, 0) == 0)
        {
                Debug.Log("Condition is required");
                if (PlayerPrefs.GetInt(conditionName, 0) == 1 && PlayerPrefs.GetInt(conditionName2, 0) == 1
                    && PlayerPrefs.GetInt(conditionName3, 0) == 1 && PlayerPrefs.GetInt(conditionName4, 0) == 1
                    && PlayerPrefs.GetInt(conditionName5, 0) == 1)
                {
                    instructionPanel.SetActive(true);
                    seenInstruction = true;
                    PlayerPrefs.SetInt(playerPrefVariableName, 1);
                }
        }
    }
}
