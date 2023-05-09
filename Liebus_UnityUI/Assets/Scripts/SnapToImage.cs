using UnityEngine;
using UnityEngine.EventSystems;

public class SnapToImage : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public RectTransform imageToSnapTo;

    private RectTransform rectTransform;
    private Canvas canvas;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor / 7;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);

        // Check if any corner of this image overlaps with the other image
        for (int i = 0; i < 4; i++)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(imageToSnapTo, corners[i], Camera.main))
            {
                // Snap this image to the other image
                rectTransform.anchoredPosition = imageToSnapTo.anchoredPosition;
                break;
            }
            else
            {
                // Snap this image back to its initial position
                rectTransform.anchoredPosition = new Vector2(0f, 0f);
            }
        }
    }
}

