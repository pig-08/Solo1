using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerEnemyHint : MonoBehaviour
{
    [SerializeField]private List<GameObject> hints;
    public static HintTextMovement[] _hintTextMovement = new HintTextMovement[3];

    public int EnemyCount { get; set; } = 0;
    public bool[] EnemyClick { get; set; } = new bool[6]; 
    public bool Click { get; set; } 

    private void Start()
    {
        foreach (var hint in hints)
        {
            hint.gameObject.SetActive(false);
        }
    }

    public void HintButtonSet(bool bools)
    {
        hints[1].SetActive(bools);
    }

    public void HintImageSet(bool bools)
    {
        hints[0].SetActive(bools);
    }
    public void HintButton()
    {
        hints[0].SetActive(true);
        if (Click)
        {
            HintTextMovement.hint[0] = "튜토리얼이라서 알려 드립니다.";
            HintTextMovement.hint[1] = "의자 입니다.";
            HintTextMovement.hint[2] = "의자의 닿으면 다음 \n튜토리얼로 넘어갑니다.";
        }
        else if (EnemyClick[0])
        {
            HintTextMovement.hint[0] = "1. 과거부터 글씨가 많은 것에는 저주가 잘 깃든다.";
            HintTextMovement.hint[1] = "2. 과거에도 4번 불길한 숫자였다.";
            HintTextMovement.hint[2] = "3. 옆을 보고 있는 것은 포함하지 않는다.";
        }
        else if (EnemyClick[1])
        {
            HintTextMovement.hint[0] = "1. 자신을 마주 보는 것은 힘든일이다.";
            HintTextMovement.hint[1] = "2. 용변을 보는 곳에 있는 물건은 저주가 잘 깃든다.";
            HintTextMovement.hint[2] = "3. 깨지기 쉬운 것 은 저주가 좋아한다.";
        }
        foreach (var hint in _hintTextMovement)
            hint.SetText();
    }
}

