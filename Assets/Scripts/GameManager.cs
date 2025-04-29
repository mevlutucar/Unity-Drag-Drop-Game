using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int correctDrop=0;
    public int wrongDrop =0;

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

        if (wrongDrop >=3)
        {
            Debug.Log("Hay aksi! oyunda baþarýlý olamadýnýz!");
        }
    }
}
