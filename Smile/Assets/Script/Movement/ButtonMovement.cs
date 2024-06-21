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
    public string _Location { get; set; }
    private void Awake()
    {
        
        _playerPosition = FindObjectOfType<PlayerPosition>();
        _playerMove = FindObjectOfType<PlayerMove>();
        _playerInput = FindObjectOfType<PlayerInput>();
        _playerEnemyHint = FindObjectOfType<PlayerEnemyHint>();
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
        SceneManager.LoadScene("TutorialScene");
        _playerPosition.PlayerVector();
        _playerPosition.SceneLocation();
    }

    public void Home()
    {
        SceneManager.LoadScene(_playerPosition.SceneName);
        _playerMove.Battle = true;
        _playerPosition.HomeMovement();
        _playerPosition.SceneLocation();
        _playerInput.IsTrigger();
        _playerEnemyHint.EnemyClick[++_playerEnemyHint.EnemyCount] = true;
        _playerInput.EnemeyCount[_playerEnemyHint.EnemyCount - 1] = true;
        if (_playerPosition.BattleScene == 1) _playerPosition.FirstEnemy = true;
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Restart()
    {
        _playerPosition.PlayerDelete();
        SceneManager.LoadScene("StartScenes");
    }


}
