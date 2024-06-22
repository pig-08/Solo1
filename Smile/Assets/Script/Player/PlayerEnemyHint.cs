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
            HintTextMovement.hint[0] = "Ʃ�丮���̶� �˷� �帳�ϴ�.";
            HintTextMovement.hint[1] = "���� �Դϴ�.";
            HintTextMovement.hint[2] = "������ ������ ���� \nƩ�丮��� �Ѿ�ϴ�.";
        }
        else if (EnemyClick[0])
        {
            HintTextMovement.hint[0] = "1. ���ź��� �۾��� ���� �Ϳ��� ���ְ� �� ����.";
            HintTextMovement.hint[1] = "2. ���ſ��� 4�� �ұ��� ���ڿ���.";
            HintTextMovement.hint[2] = "3. ���� ���� �ִ� ���� �������� �ʴ´�.";
        }
        else if (EnemyClick[1])
        {
            HintTextMovement.hint[0] = "1. �ڽ��� ���� ���� ���� �������̴�.";
            HintTextMovement.hint[1] = "2. �뺯�� ���� ���� �ִ� ������ ���ְ� �� ����.";
            HintTextMovement.hint[2] = "3. ������ ���� �� �� ���ְ� �����Ѵ�.";
        }
        foreach (var hint in _hintTextMovement)
            hint.SetText();
    }
}

