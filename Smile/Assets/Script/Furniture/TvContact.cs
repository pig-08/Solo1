using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvContact : MonoBehaviour
{
    private BattleButtonMovement _battleButtonMovement;
    public BoxCollider2D BoxCollider { get;private set; }
    private void Awake()
    {
        _battleButtonMovement = FindObjectOfType<BattleButtonMovement>();
        BoxCollider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _battleButtonMovement.Window(0);
    }
}
