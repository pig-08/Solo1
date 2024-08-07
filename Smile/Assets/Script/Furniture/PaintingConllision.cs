using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingConllision : MonoBehaviour
{
    private BattleButtonMovement _battleButtonMovement;
    private PlayerPosition _playerPosition;
    private PlayerEnemyHint _enemyHint;
    public BoxCollider2D BoxCollider { get; private set; }
    private void Awake()
    {
        _battleButtonMovement = FindObjectOfType<BattleButtonMovement>();
        _playerPosition = FindObjectOfType<PlayerPosition>();
        _enemyHint = FindObjectOfType<PlayerEnemyHint>();
        BoxCollider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_enemyHint.EnemyClick[2])
        {
            _battleButtonMovement.Window(3);
            _playerPosition.BattleScene = 0;
        }
    }
}
