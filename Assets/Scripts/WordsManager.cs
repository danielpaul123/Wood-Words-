using DG.Tweening;
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
    public GameObject spawnLetterBalls;
    public Vector3 letterBalldestinatio;
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
    public void SpawnLetterBalls()
    {
        GameObject spawnedLetterBall = Instantiate(spawnLetterBalls, Vector3.zero, Quaternion.identity);
        spawnedLetterBall.transform.DOMove(new Vector3(-1.6257f, 3.77f, 0f), 1f).SetEase(Ease.OutQuad);
    }
}
