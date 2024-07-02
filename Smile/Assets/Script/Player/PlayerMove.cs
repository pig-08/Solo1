using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerAnimation _playerAnimation;
    private int _Speed = 5;
    private Rigidbody2D _playerrigid;
    public bool Battle {private get; set; } = true;
    public int _StartTalkCount { get; set; }
    public int _FirstTalkCount { get; set; }
    public int _BookTalkCount { get; set; }

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerAnimation = GetComponent<PlayerAnimation>();
        _playerrigid = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(this);
    }
    private void FixedUpdate()
    {
        if (Battle)
        {
            _playerInput.Move();
            _playerAnimation.MoveAni();
            _playerrigid.velocity = _playerInput._movedir.normalized * _Speed;
        }
        else if (!Battle)
        {
            _playerrigid.velocity = new Vector2(0, 0);
        }
    }
}

