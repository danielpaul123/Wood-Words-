using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordBall : MonoBehaviour
{
    public string part;
    private TextMeshPro text;
    public static WordBall selectedWordBall;
    public Animator animator;
    public static int corcount;
    public static int worcount;
    public static List<string> corWords = new List<string>();
    void Start()
    {
        text = transform.GetChild(0).GetComponent<TextMeshPro>();
        text.text = part;
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetTrigger("BBall");

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
                    corcount++;
                    Debug.Log("Got Words Correct- " + corcount);
                    corWords.Add(combinedText);
                    Destroy(gameObject);
                    Destroy(selectedWordBall.gameObject);
                    ShowCorrectWords();
                }
                else
                {
                    Debug.Log(combinedText + " is NOT a valid word.");
                    worcount++;
                    Debug.Log("Got Words Wrong- " + worcount);
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
    public static void ShowCorrectWords()
    {
        foreach (string word in corWords)
        {
            foreach (char c in word)
            {
                Debug.Log("Character: " + c);
            }
        }
    }
}

