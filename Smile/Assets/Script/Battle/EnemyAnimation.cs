using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator _animator;
    private readonly int green = Animator.StringToHash("Green");
    private readonly int red = Animator.StringToHash("Red");
    private readonly int fish = Animator.StringToHash("Fish");
    private readonly int white = Animator.StringToHash("White");
    private readonly int yellow = Animator.StringToHash("Yellow");
    private PlayerEnemyHint _playerEnemyHint;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _playerEnemyHint = FindObjectOfType<PlayerEnemyHint>();
        _animator.SetBool(green, _playerEnemyHint.EnemyCount == 1);
        _animator.SetBool(red, _playerEnemyHint.EnemyCount == 2);
        _animator.SetBool(fish, _playerEnemyHint.EnemyCount == 3);
        _animator.SetBool(white, _playerEnemyHint.EnemyCount == 4);
        _animator.SetBool(yellow, _playerEnemyHint.EnemyCount == 5);
    }
}
