using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    RectTransform rectTransform;
    Canvas canvas;
    CanvasGroup canvasGroup;

    Vector2 firstPosition;

    public bool isDroppedRightPos = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>(); //Parent nesnesinin canvasina ulastik.

    }

    private void Start()
    {
        firstPosition = rectTransform.anchoredPosition;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (isDroppedRightPos) return;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false; //nesnenin tiklanabilirlik ozelligini kapat.
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDroppedRightPos) return;
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;

        if (!isDroppedRightPos)
        {
            rectTransform.DOAnchorPos(firstPosition, 0.3f).SetEase(Ease.OutBounce);
        }
    }
}
