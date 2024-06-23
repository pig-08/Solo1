using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private readonly int Anix = Animator.StringToHash("X");
    private readonly int Aniy = Animator.StringToHash("Y");

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void MoveAni()
    {
        _animator.SetFloat(Anix, _playerInput._movedir.x);
        _animator.SetFloat(Aniy, _playerInput._movedir.y);
        if (_playerInput._movedir.x < 0)
            _spriteRenderer.flipX = true;
        else if (_playerInput._movedir.x > 0)
            _spriteRenderer.flipX = false;
    }

    public void PlayerActive()
    {
        gameObject.SetActive(true);
    }

    public void Animationfalse()
    {
        _animator.SetFloat(Anix, 0);
        _animator.SetFloat(Aniy, 0);
    }

    public void ENDAnimeon()
    {
        _animator.SetFloat(Anix, 1);
    }
}
