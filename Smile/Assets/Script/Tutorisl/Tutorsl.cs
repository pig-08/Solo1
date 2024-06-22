using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tutorsl : MonoBehaviour
{
    private GameObject _player;
    private PlayerEnemyHint _playerEnemyHint;
    private TutorslText _tutorslText;
    public bool Click { get; set; } = true;
    private void Awake()
    {
        _player = GameObject.Find("Player");
        _tutorslText = FindObjectOfType<TutorslText>();
        _playerEnemyHint = _player.GetComponent<PlayerEnemyHint>();
    }

    private void Update()
    {
        if (_player.transform.position.x >= 19)
        {
            _tutorslText.Second();
            if (Click)
            {
                _playerEnemyHint.HintButtonSet(true);
                _playerEnemyHint.Click = true;
            }
        }
        else if (_player.transform.position.x >= 17)
        {
            _tutorslText.First();
            _playerEnemyHint.HintButtonSet(false);
        }
    }
}
