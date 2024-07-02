using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMovement : MonoBehaviour
{
    private PlayerPosition _playerPosition;
    private PlayerMove _playerMove;
    private PlayerInput _playerInput;
    private PlayerEnemyHint _playerEnemyHint;
    private TurtorislcCheckM _turtorislcCheck;
    public string _Location { get; set; }
    private void Awake()
    {
        _playerPosition = FindObjectOfType<PlayerPosition>();
        _playerMove = FindObjectOfType<PlayerMove>();
        _playerInput = FindObjectOfType<PlayerInput>();
        _playerEnemyHint = FindObjectOfType<PlayerEnemyHint>();
        _turtorislcCheck = FindObjectOfType<TurtorislcCheckM>() == null? _turtorislcCheck = null : FindObjectOfType<TurtorislcCheckM>();
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Window(bool i)
    {
        gameObject.SetActive(i);
    }
    public void No()
    {
        gameObject.SetActive(false);
    }
    public void Yes()
    {
        SceneManager.LoadScene(_Location);
        _playerPosition.SceneLocation();
        _playerPosition.PositionChange();
    }
    public void PLAY()
    {
        if (_turtorislcCheck == null)
        {
            SceneManager.LoadScene("TutorialScene");
            _playerPosition.PlayerVector();
            _playerPosition.SceneLocation();
        }
        else if (_turtorislcCheck!= null)
        {
            SceneManager.LoadScene("BedRoom");
            _playerEnemyHint.GameExitButtonSet(true);
            _playerPosition.PlayerVector();
            _playerPosition.SceneLocation();
        }
    }

    public void Home()
    {
        SceneManager.LoadScene(_playerPosition.SceneName);
        _playerMove.Battle = true;
        _playerPosition.HomeMovement();
        _playerPosition.SceneLocation();
        _playerInput.IsTrigger();
        _playerEnemyHint.HintButtonSet(true);
        _playerEnemyHint.Hidee = false;
        _turtorislcCheck.EnemyCount++;
        if (_playerEnemyHint.EnemyCount == 5)
        {
            _playerPosition.ENDPosition();
            _playerEnemyHint.HintButtonSet(false);
            SceneManager.LoadScene("ENDScene");
        }
        else if (_playerEnemyHint.EnemyCount > 0) _playerEnemyHint.EnemyClick[_playerEnemyHint.EnemyCount - 1] = false;
        _playerEnemyHint.EnemyClick[_playerEnemyHint.EnemyCount++] = true;
        _playerInput.EnemeyCount[_playerEnemyHint.EnemyCount - 1] = true;
        if (_playerPosition.BattleScene == 1) _playerPosition.FirstEnemy = true;
        else if (_playerPosition.BattleScene == 2) _playerPosition.book = true;

    }

    public void GameOver()
    {
        _turtorislcCheck.DeathCount++;
        SceneManager.LoadScene("GameOver");
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
