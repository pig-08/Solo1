using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs2 : MonoBehaviour
{
    private ButtonMovement _buttonWindow;
    private TextMovement _textMovement;
    private void Awake()
    {
        _textMovement = FindObjectOfType<TextMovement>();
        _buttonWindow = FindObjectOfType<ButtonMovement>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _buttonWindow.Window(true);
        _buttonWindow._Location = "FirstFloor";
        _textMovement.TextSetting("1��");
    }
}
