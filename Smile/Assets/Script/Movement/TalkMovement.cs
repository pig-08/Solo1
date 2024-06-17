using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkMovement : MonoBehaviour
{
    private string[] Startt = new string[3] { "이사를 온 이후로 쭉 악몽을 꾸고 있어..", "원인을 찾아 악몽에서 벗어나자!", "생각해보니 요즘 새벽에 TV가 자주 켜지던데 한번 가볼까?" };
    private string[] First = new string[4] { "저주을 해치웠다!!", "어? 이건 뭐지??", "다음 저주의 위치의 힌트지 인가보다!", "다음 저주를 찾아 모든 저주를 해치우자"};
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
