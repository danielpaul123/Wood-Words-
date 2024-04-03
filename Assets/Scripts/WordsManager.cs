using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordsManager : MonoBehaviour
{
    public static WordsManager instance;
    public TextMeshPro wordPanelText;
    public List<string> validWords;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }
    public void ShowWordInPanel(string text)
    {
        wordPanelText.text = text;
    }
    public bool CheckIfValidWord(string word)
    {
        return validWords.Contains(word);
    }
}
