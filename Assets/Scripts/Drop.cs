using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Debug = UnityEngine.Debug;

public class DropSpot : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData)
    {

        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

        }

    }

}
