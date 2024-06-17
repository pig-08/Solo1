using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkMovement : MonoBehaviour
{
    private string[] Startt = new string[3] { "�̻縦 �� ���ķ� �� �Ǹ��� �ٰ� �־�..", "������ ã�� �Ǹ����� �����!", "�����غ��� ���� ������ TV�� ���� �������� �ѹ� ������?" };
    private string[] First = new string[4] { "������ ��ġ����!!", "��? �̰� ����??", "���� ������ ��ġ�� ��Ʈ�� �ΰ�����!", "���� ���ָ� ã�� ��� ���ָ� ��ġ����"};
    private TextMeshProUGUI _textMeshProUGUI;
    [SerializeField]private static GameObject _image1;
    [SerializeField]private static GameObject _image2;
    private PlayerMove _playerMove;

    private void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        _playerMove = FindObjectOfType<PlayerMove>();
        if (gameObject.name[5] - 48 == 1)
        {
            _image1 = gameObject;
            _playerMove.Battle = false;
        }
        if (gameObject.name[5] - 48 == 4)
        { 
            _image2 = gameObject; 
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (gameObject.name[5] - 48 == 2)
        {
            if (_playerMove._Count <= Startt.Length)
                StartTalk();
        }
        
    }
    public void StartTalk()
    {
        if (gameObject.name[5] - 48 == 2)
        {
            if (_playerMove._Count == 0)
                _textMeshProUGUI.text = Startt[_playerMove._Count++];
            else if (_playerMove._Count < Startt.Length)
            {
                if (Input.GetButtonDown("Fire1"))
                    _textMeshProUGUI.text = Startt[_playerMove._Count++];
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
}
