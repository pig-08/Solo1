using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector3 _movedir { get; private set; }
    public PlayerPosition _position;
    public GameObject _talkMovement { private get; set; }
    private TvContact _tvContact;
    private PlayerEnemyHint _enemyHint;
    public bool[] EnemeyCount { get; set; } = new bool[6];
    
    private void Awake()
    {
        _position = GetComponent<PlayerPosition>();
        _enemyHint = GetComponent<PlayerEnemyHint>();
        EnemeyCount[0] = true;
    }
    public void ObjectGet()
    {
        _tvContact = FindObjectOfType<TvContact>() == null ? _tvContact = null : FindObjectOfType<TvContact>();
    }

    private void Update()
    {
        if (_position.FirstEnemy)
        {
            _talkMovement.SetActive(true);
            _position.FirstEnemy = false;
        }
    }
    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        _movedir = new Vector3(x, y);
    }

    public void IsTrigger()
    {
        StartCoroutine(IsTriggerTIme());
    }

    private IEnumerator IsTriggerTIme()
    {
        yield return null;
        if (EnemeyCount[0])
        {
            _enemyHint.Hide = true;
            _tvContact.BoxCollider.isTrigger = true;
            EnemeyCount[0] = false;
        }
    }

}
