using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Behavior : MonoBehaviour
{
    public GameObject player;
    public GameObject panel;
    public GameObject text;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < 3f && LevelManager.FoundAll)
        {
            Debug.Log("Open!");
            transform.localPosition += new Vector3(0, 0, -0.2f);
            transform.Rotate(Vector3.up * -160);
        }
        else if (distance < 3f && !LevelManager.FoundAll)
        {
            panel.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
        }
    }
}
