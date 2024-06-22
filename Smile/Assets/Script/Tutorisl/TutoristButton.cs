using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutoristButton : MonoBehaviour
{
    private PlayerMove _playerMove;
    private PlayerPosition _playerPosition;
    private PlayerEnemyHint _enemyHint;
    private Tutorsl _tutorsl;
    private void Awake()
    {
        _playerMove = FindObjectOfType<PlayerMove>();
        _playerPosition = FindObjectOfType<PlayerPosition>();
        _enemyHint = FindObjectOfType<PlayerEnemyHint>();
        _tutorsl = FindObjectOfType<Tutorsl>();
    }
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Window()
    {
        gameObject.SetActive(true);
    }

    public void No()
    {
       
        gameObject.SetActive(false);
    }

    public void Yes()
    {
        _tutorsl.Click = false;
        _enemyHint.Click = false;
        _enemyHint.HintButtonSet(false);
        SceneManager.LoadScene("TutorislBattleSecene");
        _playerPosition.BattlePosition();
        _playerMove.Battle = false;
    }
}
