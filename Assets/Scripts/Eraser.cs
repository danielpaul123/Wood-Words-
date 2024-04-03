using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    public int EreaserCount;
    private void OnMouseDown()
    {
        EreaserCount++;
        Debug.Log("Ereaser Used - "+EreaserCount);
        WordBall currentSelectedWordBall = WordBall.GetselectedWordBall();
        WordBall.selectedWordBall = null;
        WordsManager.instance.ShowWordInPanel("");
    }
}
