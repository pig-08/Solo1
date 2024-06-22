using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTutorisl : MonoBehaviour
{
    private TutoristButton _tutoristButton;
    private void Awake()
    {
        _tutoristButton = FindObjectOfType<TutoristButton>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _tutoristButton.Window();
    }
}
