using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int correctDrop = 0;
    public int wrongDrop = 0;
    public int defaultRight = 3;
    public int remainingRight;

    [SerializeField]
    GameObject remainingImg1;

    [SerializeField]
    GameObject remainingImg2;

    [SerializeField]
    GameObject remainingImg3;

    [SerializeField]
    TextMeshProUGUI rmnText;

    [SerializeField]
    Sprite rmnSprite;

    [SerializeField]
    Sprite wrngSprite;

    [SerializeField]
    Transform dragObjects;

    private void Start()
    {
        remainingRight = defaultRight;
        rmnText.text = $"Kalan Hak Sayýsý: {remainingRight} ";
    }

    public void increaseCorrectDrop()
    {
        correctDrop++;

        if (correctDrop == 5)
        {
            Debug.Log("Tebrikler oyunu baþarýyla tamamladýnýz!");
        }
        else
        {
            Debug.Log($"Oyun devam ediyor... Doðru yapýlan eþleþtirme sayýsý: {correctDrop}");
        }
    }
    public void increaseWrongDrop()
    {
        wrongDrop++;

        if (wrongDrop == 1)
        {
            remainingImg1.GetComponent<Image>().sprite = wrngSprite;
            rmnText.text = $"Kalan Hak Sayýsý: {remainingRight -= 1} ";

        }

        else if (wrongDrop == 2)
        {

            remainingImg2.GetComponent<Image>().sprite = wrngSprite;
            rmnText.text = $"Kalan Hak Sayýsý: {remainingRight -= 1} ";

        }

        if (wrongDrop >= 3)
        {
            remainingImg3.GetComponent<Image>().sprite = wrngSprite;
            rmnText.text = $"Kalan Hak Sayýsý: {remainingRight -= 1} ";
            Debug.Log("Hay aksi! oyunda baþarýlý olamadýnýz!");

            Invoke("makeDisableDragObjects", 1f);
        }
    }

    void makeDisableDragObjects()
    {
        foreach (Transform child in dragObjects)
        {
            child.GetComponent<DragDrop>().enabled = false;
        }
    }
}
