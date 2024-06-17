using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMovement : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;
    private string[] Start = new string[3] { "�̻縦 �� ���ķ� �� �Ǹ��� �ٰ� �־�..", "������ ã�� �Ǹ����� �����!", "�����غ��� ���� ��� TV�� ���� �������� �ѹ� ������?" };

    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void TextSetting([SerializeField] string i)
    {
        _textMeshProUGUI.text = $"{i}����\n���ðڽ��ϱ�?";
    }

    public void Talk()
    {

    }
}
