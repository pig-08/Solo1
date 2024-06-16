using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleButtonMovement : MonoBehaviour
{
    private PlayerPosition _playerPosition;
    private PlayerMove _playerMove;
    private ImageMovement _imageMovement;
    private void Awake()
    {
        _playerPosition = FindObjectOfType<PlayerPosition>();
        _playerMove = FindObjectOfType<PlayerMove>();
        _imageMovement = FindObjectOfType<ImageMovement>();
    }
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Window(int i)
    {
        gameObject.SetActive(true);
        _imageMovement.ImageCheck(i);
        _playerPosition.BattlePresentPosition();
    }

    public void No()
    {
        gameObject.SetActive(false);
    }

    public void Yes()
    {
        SceneManager.LoadScene("BattleScene");
        _playerPosition.BattlePosition();
        _playerMove.Battle = false;
    }
}
