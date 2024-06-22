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
        _textMeshPro[0].text = "1층";
        _textMeshPro[1].text = "WASD와 방향키로 이동할 수 있으며 \n문과 계단으로 방과 층을 \n이동할 수 있습니다.";
        _textMeshPro[2].fontSize = 100;
        _textMeshPro[2].text = "       #튜토리얼";
    }
    public void Second()
    {
        _textMeshPro[0].text = "2층";
        _textMeshPro[1].text = "물체와 접촉해 저주를 찾을 수 있으며 \n?버튼으로 힌트를 볼 수 있고 \n저주는 층과 방 상관없이 있습니다.";
        _textMeshPro[2].text = "";
    }
}
