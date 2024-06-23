using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ENDText : MonoBehaviour
{
    [SerializeField]private static TextMeshPro[] _textMeshProUGUI = new TextMeshPro[4];
    [SerializeField]private TurtorislcCheckM _turtorislcCheckM;
    private void Awake()
    {
        _turtorislcCheckM = FindObjectOfType<TurtorislcCheckM>();
        _textMeshProUGUI[gameObject.name[4] - 48] = GetComponent<TextMeshPro>();
        _textMeshProUGUI[0].text = $"���ձ⸦ ������ Ƚ�� : {_turtorislcCheckM.LineSuccessCount}";
        _textMeshProUGUI[1].text = $"���ձ⸦ ������ Ƚ�� : {_turtorislcCheckM.LineFailCount}";
        _textMeshProUGUI[2].text = $"���ָ� óġ�� Ƚ�� : {_turtorislcCheckM.EnemyCount}";
        _textMeshProUGUI[3].text = $"����� Ƚ�� : {_turtorislcCheckM.DeathCount}";
    }
}
