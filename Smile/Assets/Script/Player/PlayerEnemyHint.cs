using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEnemyHint : MonoBehaviour
{
    [SerializeField]private List<GameObject> hints;
    private PlayerPosition _playerPosition;
    public static HintTextMovement[] _hintTextMovement = new HintTextMovement[3];
    private int fontSize = 8;
    [field:SerializeField]public int EnemyCount { get; set; } = 0;
    public bool[] EnemyClick { get; set; } = new bool[6];
    public bool Click { get; set; }
    public bool Hide { get; set; }
    public bool Hidee { get; set; }
    private void Start()
    {
        _playerPosition = GetComponent<PlayerPosition>();
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

    public void GameExitButtonSet(bool bools)
    {
        hints[2].SetActive(bools);
    }

    public void GameExit(bool bools)
    {
        hints[3].SetActive(bools);
        if(Hide) HintButtonSet(!bools);
        else if(Hidee) HintButtonSet(false);
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
            HintTextMovement.Hint[1] = "2. �뺯�� ���� ���� \n�ִ� ������ ���ְ� \n�� ���� �����̴�."; HintTextMovement.Size[1] = fontSize-1;
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
    public void Restart()
    {
        _playerPosition.PlayerDelete();
        SceneManager.LoadScene("StartScenes");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

