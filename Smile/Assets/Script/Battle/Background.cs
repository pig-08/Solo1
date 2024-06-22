using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private PlayerEnemyHint _playerEnemyHint;
    private SpriteRenderer _spriteRenderer;
    [SerializeField]private Sprite[] _sprite = new Sprite[6];
    
    private void Awake()
    {
        _playerEnemyHint = FindObjectOfType<PlayerEnemyHint>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = _sprite[_playerEnemyHint.EnemyCount];
    }
}
