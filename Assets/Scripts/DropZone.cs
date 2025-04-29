using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    TextMeshProUGUI dropZoneTMP;

    GameManager gameManager;

    private void Awake()
    {
        dropZoneTMP = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObject = eventData.pointerDrag;

        if (droppedObject != null)
        {
            DragDrop dragDrop = droppedObject.GetComponent<DragDrop>();

            if (droppedObject.name == gameObject.name)
            {
                dragDrop = droppedObject.GetComponent<DragDrop>();

                dragDrop.GetComponent<RectTransform>().DOAnchorPos(GetComponent<RectTransform>().anchoredPosition, 0.1f);

                dragDrop.isDroppedRightPos = true;
                dropZoneTMP.text = string.Empty;
                gameManager.increaseCorrectDrop();

            }
            else
            {
                dragDrop.isDroppedRightPos = false;
                gameManager.increaseWrongDrop();
            }

        }
        

    }
}
