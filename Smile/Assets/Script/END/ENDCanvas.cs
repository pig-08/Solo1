using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDCanvas : MonoBehaviour
{
    [SerializeField] private GameObject title;
    [SerializeField] private GameObject[] button = new GameObject[2];
    [SerializeField] private GameObject Text;
    private PlayerMove _playerMove;
    private GameObject Player;
    private Rigidbody2D _rigidbody2d;
    private PlayerAnimation _playerAnimation;
    private bool Check = true;
    private void Awake()
    {
        Player = GameObject.Find("Player");
        _playerMove = Player.GetComponent<PlayerMove>();
        _playerAnimation = Player.GetComponent<PlayerAnimation>();
        _rigidbody2d = Player.GetComponent<Rigidbody2D>();
        _playerMove.Battle = false;
    }
    private void Update()
    {
        if(Player.transform.position.x >= 107 )
        {
            Check = false;
            title.SetActive(true);
            foreach(GameObject button in button) button.SetActive(true);
            Text.SetActive(true);
            Player.transform.position = new Vector2(107, 0);
            _playerAnimation.Animationfalse();
        }
    }

    private void FixedUpdate()
    {
        if(Check)
        {
            _rigidbody2d.velocity = Vector2.right * 5;
            _playerAnimation.ENDAnimeon();
        }
    }

}
