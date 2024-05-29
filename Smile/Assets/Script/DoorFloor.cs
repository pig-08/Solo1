using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFloor : MonoBehaviour
{
    [SerializeField]private ButtonMovement _buttonWindow;
    private TextMovement _textMovement;
    private Animator _animator;
    private readonly int _door = Animator.StringToHash("Door");
    private void Awake()
    {
        _textMovement = FindObjectOfType<TextMovement>();
        _buttonWindow = FindObjectOfType<ButtonMovement>();
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _buttonWindow.Window(true);
        _buttonWindow._Location = "Bed";
        _textMovement.TextSetting("Ä§½Ç");
        _animator.SetBool(_door, true);
    }
}
