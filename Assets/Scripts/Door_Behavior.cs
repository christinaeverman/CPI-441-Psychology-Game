using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Behavior : MonoBehaviour
{
    public GameObject player;
    public GameObject panel;
    public GameObject text;
    private float Timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0.0f && Timer < 30f)
            Timer += 1f;
        if (Timer > 30f)
        {
            panel.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
            Timer = 0.0f;
        }
    }

    void OnMouseDown()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < 3f && LevelManager.FoundAll)
        {
            Debug.Log("Open!");
        }
        else if (distance < 3f && !LevelManager.FoundAll)
        {
            panel.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
            Timer += 1f;
        }
    }
}
