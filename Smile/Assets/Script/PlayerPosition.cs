using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField]private bool _FirstFloor;
    [SerializeField]private bool _SecondFloor;
    [SerializeField]private bool _BedRoom;
    private void Awake()
    {
        DontDestroyOnLoad(this);
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
            transform.position = new Vector3(0.8f, 1.5f);
            _BedRoom = false;
        }
        else if (_FirstFloor && _BedRoom && SceneManager.GetActiveScene().name == "BedRoom")
        {
            transform.position = new Vector3(-1, -2);
            _FirstFloor = false;
        }
    }

    public void SceneLocation()
    {
        StartCoroutine(SceneLocationTime());
    }

    private IEnumerator SceneLocationTime()
    {
        yield return null;
        if (SceneManager.GetActiveScene().name == "FirstFloor")
        {
            _FirstFloor = true;
        }
        else if (SceneManager.GetActiveScene().name == "SecondFloor")
        {
            _SecondFloor = true;
        }
        else if (SceneManager.GetActiveScene().name == "BedRoom")
        {
            _BedRoom = true;
        }
    }

    public void PlayerVector()
    {
        StartCoroutine(PlayerVectorTime());
    }

    private IEnumerator PlayerVectorTime()
    {
        yield return null;
        transform.position = new Vector3(-4.5f, 1);
    }
}
