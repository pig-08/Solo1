using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerEnemyHint : MonoBehaviour
{
    [SerializeField]private List<GameObject> hints;
    public static HintTextMovement[] _hintTextMovement = new HintTextMovement[3];
    private int fontSize = 8;
    public int EnemyCount { get; set; } = 0;
    [field:SerializeField]public bool[] EnemyClick { get; set; } = new bool[5];
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
            HintTextMovement.Hint[0] = "Ʃ�丮���̶� �˷� �帳�ϴ�."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "���� �Դϴ�."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "������ ������ ���� \nƩ�丮��� �Ѿ�ϴ�."; HintTextMovement.Size[2] = fontSize;

        }
        else if (EnemyClick[0])
        {
            HintTextMovement.Hint[0] = "1. ���ź��� �۾��� ���� �Ϳ��� ���ְ� �� ����."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. ���ſ��� 4�� �ұ��� ���ڿ���."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "3. ���� ���� �ִ� ���� �������� �ʴ´�."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[1])
        {
            HintTextMovement.Hint[0] = "1. �ڽ��� ���� ���� ���� �������̴�."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. 2. �뺯�� ���� ���� \n�ִ� ������ ���ְ� \n�� ���� �����̴�."; HintTextMovement.Size[1] = fontSize-1;
            HintTextMovement.Hint[2] = "3. ������ ���� �� �� \n���ְ� �����Ѵ�."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[2])
        {
            HintTextMovement.Hint[0] = "1. ���ֵ� �̻� �� �� �����Ѵ�."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. ���� �پ��� ���� �ִ� �Ϳ� ���ְ� ���⵵ �Ѵ�."; HintTextMovement.Size[1] = fontSize-1;
            HintTextMovement.Hint[2] = "3. ������ �ƴ� �ٸ� ����.."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[3])
        {
            HintTextMovement.Hint[0] = "1. ���ź��� ���ִ� ����� �ǰ�;���."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. �ΰ��� �ƴ����� ����� ����ϰ� ���� ��.."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "3. ����� ���� ��� ������ �ִ� ����.."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[4])
        {
            HintTextMovement.Hint[0] = "1. ���� ���� ��Ӵ�."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. ������ ��������  �ߺ����Ѵ�."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "3. �� ���� �ű⼭ ���ۉ��. "; HintTextMovement.Size[2] = fontSize;
        }
        foreach (var hint in _hintTextMovement)
            hint.SetText();
    }
}

