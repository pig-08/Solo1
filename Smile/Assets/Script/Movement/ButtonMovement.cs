using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMovement : MonoBehaviour
{
    private PlayerPosition _playerPosition;
    private PlayerMove _playerMove;
    private PlayerInput _playerInput;
    public string _Location { get; set; }
    private void Awake()
    {
        
        _playerPosition = FindObjectOfType<PlayerPosition>();
        _playerMove = FindObjectOfType<PlayerMove>();
        _playerInput = FindObjectOfType<PlayerInput>();
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
        SceneManager.LoadScene("BedRoom");
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
    }


}
