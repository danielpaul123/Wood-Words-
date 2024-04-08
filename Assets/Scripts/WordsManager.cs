using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class WordsManager : MonoBehaviour
{
    public static WordsManager instance;
    public TextMeshPro wordPanelText;
    public List<string> validWords;
    public GameObject winPanel;
    public GameObject letterBalls;
    public List<Transform> letterBallDestination;
    public GameObject losePanel;
    public TextMeshPro hint;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        ShowHint("");
    }
    private void Update()
    {
        if (WordBall.corcount == 2)
        {
            winPanel.SetActive(true);
        }
        if (WordBall.worcount == 3) 
        { 
           losePanel.SetActive(true);
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
    public void DisplayCorrectWords(string correctWord)
    {
        wordPanelText.text = correctWord;
        Debug.Log("From WordManager- " + correctWord);
    }

    public void SpawnLetterBalls(string correctWord)
    {
        for (int i = 0; i < correctWord.Length; i++)
        {
            char c = correctWord[i];
            Transform destination = letterBallDestination[i];

            GameObject spawnedLetterBall = Instantiate(letterBalls, Vector3.zero, Quaternion.identity);
            spawnedLetterBall.GetComponentInChildren<TextMeshPro>().text = c.ToString();
            spawnedLetterBall.transform.DOMove(destination.position, 1f).SetEase(Ease.OutQuad);
        }
    }

    public void ShowHint(string hintMessage)
    {
        hint.text = hintMessage;
        hint.transform.DOScale(Vector3.one * 1.2f, 1f).SetLoops(-1, LoopType.Yoyo);
    }
}