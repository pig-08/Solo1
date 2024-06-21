using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector3 _movedir { get; private set; }
    public PlayerPosition _position;
    public GameObject _talkMovement { private get; set; }
    private TvContact _tvContact;
    [SerializeField]private BookCaseContact _bookCaseContact;
    public bool[] EnemeyCount { get; set; } = new bool[6];
    
    private void Awake()
    {
        _position = GetComponent<PlayerPosition>();
        EnemeyCount[0] = true;
    }
    public void ObjectGet()
    {
        _tvContact = FindObjectOfType<TvContact>() == null ? _tvContact = null : FindObjectOfType<TvContact>();
        _bookCaseContact = FindObjectOfType<BookCaseContact>() == null ? _bookCaseContact = null : FindObjectOfType<BookCaseContact>();
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
            _tvContact.BoxCollider.isTrigger = true;
            EnemeyCount[0] = false;
        }
        else if (EnemeyCount[1])
        {
            _bookCaseContact.BoxCollider.isTrigger = true;
            EnemeyCount[1] = false;
        }
    }

}
