using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerPosition : MonoBehaviour
{
    private bool _FirstFloor;
    private bool _SecondFloor;
    private bool _BedRoom;
    private bool _BookRoom;
    private bool _WashRoom;
    private Vector3 _position;
    private PlayerInput _playerInput;
    private CapsuleCollider2D _capsuleCollider;
    public int BattleScene { get; set;}
    public string SceneName { get;private set; }
    public bool FirstEnemy { get; set; }
    private void Awake()
    {
        DontDestroyOnLoad(this);
        _playerInput = GetComponent<PlayerInput>();
        _capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    public void PositionChange()
    {
        StartCoroutine(PositionChangeTime());
    }

    public IEnumerator PositionChangeTime()
    {
        yield return null;
        if (_FirstFloor && _SecondFloor && SceneManager.GetActiveScene().name == "FirstFloor")
        {
            transform.position = new Vector3(-4.5f, 1);
            _SecondFloor = false;
        }
        else if (_FirstFloor && _SecondFloor && SceneManager.GetActiveScene().name == "SecondFloor")
        {
            transform.position = new Vector3(-8, -0.7f);
            _FirstFloor = false;
        }
        else if (_FirstFloor && _BedRoom && SceneManager.GetActiveScene().name == "FirstFloor")
        {
            transform.position = new Vector3(-2, 1.5f);
            _BedRoom = false;
        }
        else if (_FirstFloor && _BedRoom && SceneManager.GetActiveScene().name == "BedRoom")
        {
            transform.position = new Vector3(-1, -2);
            _FirstFloor = false;
        }
        else if (_SecondFloor && _BookRoom && SceneManager.GetActiveScene().name == "SecondFloor")
        {
            transform.position = new Vector3(-6, 1.3f);
            _BookRoom = false;
        }
        else if (_SecondFloor && _BookRoom && SceneManager.GetActiveScene().name == "BookRoom")
        {
            transform.position = new Vector3(0, -2);
            _SecondFloor = false;
        }
        else if (_SecondFloor && _WashRoom && SceneManager.GetActiveScene().name == "SecondFloor")
        {
            transform.position = new Vector3(15, 1.3f);
            _WashRoom = false;
        }
        else if (_SecondFloor && _WashRoom && SceneManager.GetActiveScene().name == "WashRoom")
        {
            transform.position = new Vector3(3, -1.8f);
            _SecondFloor = false;
        }
    }

    public void SceneLocation()
    {
        StartCoroutine(SceneLocationTime());
    }

    private IEnumerator SceneLocationTime()
    {
        yield return null;
        if (SceneManager.GetActiveScene().name == "FirstFloor")_FirstFloor = true;
        else if (SceneManager.GetActiveScene().name == "SecondFloor")_SecondFloor = true;
        else if (SceneManager.GetActiveScene().name == "BedRoom")_BedRoom = true;
        else if (SceneManager.GetActiveScene().name == "BookRoom")_BookRoom = true;
        else if(SceneManager.GetActiveScene().name == "WashRoom")_WashRoom = true;
        _playerInput.ObjectGet();
    }

    public void PlayerVector()
    {
        StartCoroutine(PlayerVectorTime());
    }

    private IEnumerator PlayerVectorTime()
    {
        yield return null;
        transform.position = new Vector3(0.2f, 0.5f);
    }

    public void BattlePosition()
    {
        StartCoroutine(BattlePositionTIem());
    }

    public void BattlePresentPosition()
    {
        SceneName = SceneManager.GetActiveScene().name;
        _position = transform.position;
    }
    private IEnumerator BattlePositionTIem()
    {
        yield return null;
        transform.position = new Vector3(-7.6f, -2.4f);
    }
    public void HomeMovement()
    {
        StartCoroutine(HomeMovementTime());
    }

    private IEnumerator HomeMovementTime()
    {
        _capsuleCollider.isTrigger = true;
        yield return null;
        transform.position = _position;
        _capsuleCollider.isTrigger = false;
    }

    public void PlayerDelete()
    {
        Destroy(gameObject);
    }

    public void ENDPosition()
    {
        StartCoroutine(ENDPositionTime());
    }

    private IEnumerator ENDPositionTime()
    {
        yield return null;
        transform.position = new Vector3(-8, 0);
    }
}
