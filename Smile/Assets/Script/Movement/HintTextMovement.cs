using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HintTextMovement : MonoBehaviour
{
    public static string[] hint { get; private set; } = new string[3];
    private static TextMeshProUGUI[] _textMeshProUGUI = new TextMeshProUGUI[3];
    private PlayerEnemyHint _enemyHint;

    private void Awake()
    {
        _enemyHint = FindObjectOfType<PlayerEnemyHint>();
        PlayerEnemyHint._hintTextMovement[gameObject.name[8] - 48] = GetComponent<HintTextMovement>();
        _textMeshProUGUI[gameObject.name[8] -48] = GetComponent<TextMeshProUGUI>();
    }

    public void SetText()
    {
        _textMeshProUGUI[gameObject.name[8] - 48].text = hint[gameObject.name[8] - 48];
    }

}
