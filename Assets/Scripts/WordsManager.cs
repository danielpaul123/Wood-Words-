using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordsManager : MonoBehaviour
{
    public static WordsManager instance;
    public TextMeshPro wordPanelText;
    public List<string> validWords;
    public GameObject winPanel;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }
    private void Update()
    {
        if (WordBall.corcount == 2)
        {
            winPanel.SetActive(true);
        }
    }

    public void ShowWordInPanel(string text)
    {
        wordPanelText.text = text;
    }

    public bool CheckIfValidWord(string word)
    {
        return validWords.Contains(word);
    }

    public TextMeshPro displaytext;
    public void DisplayCorrectWords(string correctWord)
    {
        displaytext.text= correctWord;
        Debug.Log("from WordManager" + correctWord);
    }

}
