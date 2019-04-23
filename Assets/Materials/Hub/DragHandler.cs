using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    #region IBeginDragHandler implementation
    public static GameObject itemBeingDragged;
	Vector3 startPosition;
	Transform startParent;


	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
    #endregion

    #region IDragHandler implementation

    public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}

    #endregion

    #region IEndDragHander implementation

    public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if (transform.parent == startParent) 
		{
			transform.position = startPosition;
		}
	}
    #endregion
}

