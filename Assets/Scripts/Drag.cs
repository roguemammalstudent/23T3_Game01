using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using Debug = UnityEngine.Debug;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{

    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {

        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = 6f;
        //   canvasGroup.blockRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {

        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        //     canvasGroup.blockRaycastss = true;

    }

    public void OnPointerDown(PointerEventData eventData)
    {

        Debug.Log("OnPointerDown");

    }

    public void OnDrop(PointerEventData eventData)
    {

        throw new System.NotImplementedException();

    }

}
