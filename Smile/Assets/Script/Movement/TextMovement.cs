using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMovement : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;
    private string[] Start = new string[3] { "이사를 온 이후로 쭉 악몽을 꾸고 있어..", "원인을 찾아 악몽에서 벗어나자!", "생각해보니 요즘 밤애 TV가 자주 켜지던데 한번 가볼까?" };

    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void TextSetting([SerializeField] string i)
    {
        _textMeshProUGUI.text = $"{i}으로\n가시겠습니까?";
    }

    public void Talk()
    {

    }
}
