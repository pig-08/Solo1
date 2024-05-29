using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMovement : MonoBehaviour
{
    private PlayerPosition _playerPosition;
    public string _Location { get; set; }
    private void Awake()
    {
        _playerPosition = FindObjectOfType<PlayerPosition>();
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
        SceneManager.LoadScene("FirstFloor");
        _playerPosition.PlayerVector();
        _playerPosition.SceneLocation();

    }


}
