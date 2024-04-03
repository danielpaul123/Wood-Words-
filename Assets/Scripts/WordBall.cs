using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordBall : MonoBehaviour
{
    public string part;
    private TextMeshPro text;
    public static WordBall selectedWordBall;
    void Start()
    {
        text = transform.GetChild(0).GetComponent<TextMeshPro>();
        text.text = part;
    }
    private void OnMouseDown()
    {
        if (selectedWordBall == null)
        {
            selectedWordBall = this;
            WordsManager.instance.ShowWordInPanel(part);
        }
        else
        {
            if (selectedWordBall != this)
            {
                string combinedText = selectedWordBall.part + part;
                WordsManager.instance.ShowWordInPanel(combinedText);
                if (WordsManager.instance.CheckIfValidWord(combinedText))
                {
                    Debug.Log(combinedText + " is a valid word.");
                    StartCoroutine(ClearPanel());
                }
                else
                {
                    Debug.Log(combinedText + " is NOT a valid word.");
                }
                selectedWordBall = null;           
            }
        }
    }
    IEnumerator ClearPanel()
    {
        yield return new WaitForSeconds(0.4f);
        WordsManager.instance.ShowWordInPanel("");
    }
    public static WordBall GetselectedWordBall()
    {
        return selectedWordBall; 
    }
}

