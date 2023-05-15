using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Moving : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Canvas canvas;
    RectTransform rectTransform;
    private BoxCollider2D collider1;
    private bool canDrag;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        collider1 = GetComponent<BoxCollider2D>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("click");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 localCursor;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out localCursor))
        {
            canDrag = collider1.OverlapPoint(rectTransform.TransformPoint(localCursor));
        }
        Debug.Log("begin drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (canDrag)
        {
            Debug.Log("dragging");
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor / 7;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canDrag = false;
        Debug.Log("end drag");
    }
}
