using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorslText : MonoBehaviour
{
    private static TextMeshProUGUI[] _textMeshPro = new TextMeshProUGUI[3];
    private void Awake()
    {
        _textMeshPro[gameObject.name[4] - 48] = GetComponent<TextMeshProUGUI>();
    }
    public void First()
    {
        _textMeshPro[0].text = "1��";
        _textMeshPro[1].text = "WASD�� ����Ű�� �̵��� �� ������ \n���� ������� ��� ���� \n�̵��� �� �ֽ��ϴ�.";
        _textMeshPro[2].fontSize = 100;
        _textMeshPro[2].text = "       #Ʃ�丮��";
    }
    public void Second()
    {
        _textMeshPro[0].text = "2��";
        _textMeshPro[1].text = "��ü�� ������ ���ָ� ã�� �� ������ \n?��ư���� ��Ʈ�� �� �� �ְ� \n���ִ� ���� �� ������� �ֽ��ϴ�.";
        _textMeshPro[2].text = "";
    }
}
