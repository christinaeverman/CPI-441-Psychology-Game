using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour /*, IPointerEnterHandler, IPointerExitHandler*/
{
    public bool showInventory = false;

    // Audio
    AudioSource source;
    public AudioClip inventorySound;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i") && !showInventory && PlayerPrefs.GetInt("menuOpened", 0) == 0)
        {
            source.PlayOneShot(inventorySound, 0.4f);
            showInventory = true;
            GetComponent<RectTransform>().localPosition = new Vector3(0, -300, 0);
        }
        else if (Input.GetKeyDown("i") && showInventory && PlayerPrefs.GetInt("menuOpened", 0) == 0)
        {
            source.PlayOneShot(inventorySound, 0.4f);
            showInventory = false;
            GetComponent<RectTransform>().localPosition = new Vector3(0, -450, 0);
        }
    }
}
