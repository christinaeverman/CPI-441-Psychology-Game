﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        GetComponent<RectTransform>().localPosition = new Vector3(0, -300, 0);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        GetComponent<RectTransform>().localPosition = new Vector3(0, -440, 0);
    }
}