using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour /*, IPointerEnterHandler, IPointerExitHandler*/
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
            GetComponent<RectTransform>().localPosition = new Vector3(0, -300, 0);
        }
        else if (Input.GetKeyDown("i") && showInventory)
        {
            Debug.Log("Closing Inventory");
            showInventory = false;
            GetComponent<RectTransform>().localPosition = new Vector3(0, -450, 0);
        }
    }

    /*
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        GetComponent<RectTransform>().localPosition = new Vector3(0, -300, 0);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        GetComponent<RectTransform>().localPosition = new Vector3(0, -440, 0);
    }
    */
}
