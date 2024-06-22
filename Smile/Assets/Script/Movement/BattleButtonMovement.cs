using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleButtonMovement : MonoBehaviour
{
    private PlayerPosition _playerPosition;
    private PlayerMove _playerMove;
    private PlayerAnimation _playerAnimation;
    private ImageMovement _imageMovement;
    private void Awake()
    {
        _playerPosition = FindObjectOfType<PlayerPosition>();
        _playerMove = FindObjectOfType<PlayerMove>();
        _playerAnimation = FindObjectOfType<PlayerAnimation>();
        _imageMovement = FindObjectOfType<ImageMovement>();
    }
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Window(int i)
    {
        _playerMove.Battle = false;
        gameObject.SetActive(true);
        _imageMovement.ImageCheck(i);
        _playerPosition.BattlePresentPosition();
    }

    public void No()
    {
        gameObject.SetActive(false);
        _playerMove.Battle = true;
    }

    public void Yes()
    {
        SceneManager.LoadScene("BattleScene");
        _playerAnimation.Animationfalse();
        _playerPosition.BattlePosition();
    }
}
