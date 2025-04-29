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
            Debug.Log("Tebrikler oyunu ba�ar�yla tamamlad�n�z!");
        }
        else
        {
            Debug.Log($"Oyun devam ediyor... Do�ru yap�lan e�le�tirme say�s�: {correctDrop}");
        }
    }

    public void increaseWrongDrop()
    {
        wrongDrop++;

        if (wrongDrop >=3)
        {
            Debug.Log("Hay aksi! oyunda ba�ar�l� olamad�n�z!");
        }
    }
}
