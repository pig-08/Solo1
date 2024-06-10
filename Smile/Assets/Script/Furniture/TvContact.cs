using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvContact : MonoBehaviour
{
    private BattleButtonMovement _battleButtonMovement;
    private void Awake()
    {
        _battleButtonMovement = FindObjectOfType<BattleButtonMovement>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _battleButtonMovement.Window(0);
    }
}
