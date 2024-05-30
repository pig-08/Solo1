using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement : MonoBehaviour
{
    private Image _line;
    public int i;
    private void Awake()
    {
        _line = GetComponent<Image>();
    }

    private void Update()
    {
        LineCkeck();
    }

    private void LineCkeck()
    {
        if (ButtonStars._check[0] && ButtonStars._check[1] && gameObject.name == "Line3")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
        }
        else if (ButtonStars._check[0] && ButtonStars._check[2] && gameObject.name == "Line8")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
        }
    }
}
