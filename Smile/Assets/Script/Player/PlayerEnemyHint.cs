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
            HintTextMovement.Hint[0] = "튜토리얼이라서 알려 드립니다."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "의자 입니다."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "의자의 닿으면 다음 \n튜토리얼로 넘어갑니다."; HintTextMovement.Size[2] = fontSize;

        }
        else if (EnemyClick[0])
        {
            HintTextMovement.Hint[0] = "1. 과거부터 글씨가 많은 것에는 저주가 잘 깃든다."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. 과거에도 4번 불길한 숫자였다."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "3. 옆을 보고 있는 것은 포함하지 않는다."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[1])
        {
            HintTextMovement.Hint[0] = "1. 자신을 마주 보는 것은 힘든일이다."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. 용변을 보는 곳에 \n있는 물건은 저주가 \n잘 깃들기 마련이다."; HintTextMovement.Size[1] = fontSize-1;
            HintTextMovement.Hint[2] = "3. 깨지기 쉬운 것 은 \n저주가 좋아한다."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[2])
        {
            HintTextMovement.Hint[0] = "1. 저주도 이쁜 것 을 좋아한다."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. 가끔 다양한 색이 있는 것에 저주가 깃길기도 한다."; HintTextMovement.Size[1] = fontSize-1;
            HintTextMovement.Hint[2] = "3. 사진이 아닌 다른 무언가.."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[3])
        {
            HintTextMovement.Hint[0] = "1. 과거부터 저주는 사람이 되고싶었다."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. 인간은 아니지만 사람과 비슷하게 생긴 것.."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "3. 어릴때는 거의 모두 가지고 있던 물건.."; HintTextMovement.Size[2] = fontSize;
        }
        else if (EnemyClick[4])
        {
            HintTextMovement.Hint[0] = "1. 등잔 밑이 어둡다."; HintTextMovement.Size[0] = fontSize;
            HintTextMovement.Hint[1] = "2. 언제나 시작점을  잘봐야한다."; HintTextMovement.Size[1] = fontSize;
            HintTextMovement.Hint[2] = "3. 이 일은 거기서 시작됬다. "; HintTextMovement.Size[2] = fontSize;
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

