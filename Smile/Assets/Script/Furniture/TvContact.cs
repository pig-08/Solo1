using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvContact : MonoBehaviour
{
    private BattleButtonMovement _battleButtonMovement;
    private PlayerPosition _playerPosition;
    public BoxCollider2D BoxCollider { get;private set; }
    private void Awake()
    {
        _battleButtonMovement = FindObjectOfType<BattleButtonMovement>();
        _playerPosition = FindObjectOfType<PlayerPosition>();
        BoxCollider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _battleButtonMovement.Window(0);
        _playerPosition.BattleScene = 1;
    }
}
