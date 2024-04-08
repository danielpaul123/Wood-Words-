using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LettrerBall : MonoBehaviour
{
    private char letter;
    public TextMeshPro textMeshPro;

    public void SetLetter(char letter)
    {
        this.letter = letter;
        
        GetComponentInChildren<TMPro.TextMeshPro>().text = letter.ToString();
    }
}