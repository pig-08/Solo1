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
        _textMeshProUGUI[0].text = $"¼±ÀÕ±â¸¦ ¼º°øÇÑ È½¼ö : {_turtorislcCheckM.LineSuccessCount}";
        _textMeshProUGUI[1].text = $"¼±ÀÕ±â¸¦ ½ÇÆÐÇÑ È½¼ö : {_turtorislcCheckM.LineFailCount}";
        _textMeshProUGUI[2].text = $"ÀúÁÖ¸¦ Ã³Ä¡ÇÑ È½¼ö : {_turtorislcCheckM.EnemyCount}";
        _textMeshProUGUI[3].text = $"»ç¸ÁÇÑ È½¼ö : {_turtorislcCheckM.DeathCount}";
    }
}
