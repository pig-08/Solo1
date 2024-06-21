using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMovement : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;
    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void TextSetting([SerializeField] string i)
    {
        _textMeshProUGUI.text = $"{i}으로\n가시겠습니까?";
    }

}
