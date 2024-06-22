using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TalkMovement : MonoBehaviour
{
    private string[] Startt = new string[3] { "�̻縦 �� ���ķ� �� �Ǹ��� �ٰ� �־�..", "������ ã�� �Ǹ����� �����!", "�����غ��� ���� ������ TV�� ���� �������� �ѹ� ������?" };
    private string[] First = new string[4] { "������ ��ġ����!!", "��? �̰� ����??", "���� ������ ��ġ�� ��Ʈ�ΰ�����!", "���� ���ָ� ã�� ��� ���ָ� ��ġ����" };
    private TextMeshProUGUI _textMeshProUGUI;
    private static GameObject _image1;
    public static GameObject _image2;
    private PlayerMove _playerMove;
    private PlayerInput _playerInput;
    private PlayerEnemyHint _playerEnemyHint;
    private void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        _playerMove = FindObjectOfType<PlayerMove>();
        _playerInput = FindObjectOfType<PlayerInput>();
        _playerEnemyHint = FindObjectOfType<PlayerEnemyHint>();
        if (gameObject.name[5] - 48 == 1)
        {
            _image1 = gameObject;
            _playerMove.Battle = false;
            if (_playerMove._StartTalkCount == Startt.Length)
            {
                _image1.SetActive(false);
                _playerMove.Battle = true;
            }
        }
        else if (gameObject.name[5] - 48 == 4)
        {
            _playerInput._talkMovement = gameObject;
            _image2 = gameObject;
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (gameObject.name[5] - 48 == 2)
        {
            if (_playerMove._StartTalkCount <= Startt.Length) StartTalk();
        }
        else if (gameObject.name[5] - 48 == 3) 
        {
            if(_playerMove._FirstTalkCount <= First.Length) FirstEnemyTalk();
        }

    }
    private void StartTalk()
    {
        if (gameObject.name[5] - 48 == 2)
        {
            if (_playerMove._StartTalkCount == 0)
                _textMeshProUGUI.text = Startt[_playerMove._StartTalkCount++];
            else if (_playerMove._StartTalkCount < Startt.Length)
            {
                if (Input.GetButtonDown("Fire1"))
                    _textMeshProUGUI.text = Startt[_playerMove._StartTalkCount++];
            }
            else
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    _image1.SetActive(false);
                    _playerMove.Battle = true;
                }

            }
        }
    }

    private void FirstEnemyTalk()
    {
        if (gameObject.name[5] - 48 == 3)
        {
            if (_playerMove._FirstTalkCount == 0)
            {
                _textMeshProUGUI.text = First[_playerMove._FirstTalkCount++];
                _playerMove.Battle = false;
            }
            else if (_playerMove._FirstTalkCount < First.Length)
            {
                if (Input.GetButtonDown("Fire1"))
                    _textMeshProUGUI.text = First[_playerMove._FirstTalkCount++];
                else if (_playerMove._FirstTalkCount == 2)
                    _playerEnemyHint.HintButton();
                else if (_playerMove._FirstTalkCount == 3)
                    _playerEnemyHint.HintImageSet(false);
            }
            else
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    _image2.SetActive(false);
                    _playerMove.Battle = true;
                    _playerEnemyHint.HintButtonSet(true);
                }

            }
        }
    }
}