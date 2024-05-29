using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerAnimation _playerAnimation;
    [SerializeField] private int _Speed = 5;
    public event Action _MoveScene;
    private Rigidbody2D _playerrigid;
    
    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerAnimation = GetComponent<PlayerAnimation>();
        _playerrigid = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(this);
    }
    private void FixedUpdate()
    {
        _playerInput.Move();
        _playerAnimation.MoveAni();
        _playerrigid.velocity = _playerInput._movedir.normalized * _Speed;
        
    }    
}

