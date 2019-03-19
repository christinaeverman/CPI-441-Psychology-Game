using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Inventory : MonoBehaviour
{
    public bool showInventory = false;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
