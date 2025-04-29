using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    TextMeshProUGUI dropZoneTMP;

    private void Awake()
    {
        dropZoneTMP = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObject = eventData.pointerDrag;

        if (droppedObject != null)
        {
            DragDrop dragDrop = droppedObject.GetComponent<DragDrop>();

            if (droppedObject.name == "CatImg")
            {
                dragDrop = droppedObject.GetComponent<DragDrop>();

                dragDrop.GetComponent<RectTransform>().anchoredPosition
                    = GetComponent<RectTransform>().anchoredPosition;

                dragDrop.isDroppedRightPos = true;
                dropZoneTMP.text = string.Empty;

            }
            else
            {
                dragDrop.isDroppedRightPos = false;
            }

        }
        

    }
}
