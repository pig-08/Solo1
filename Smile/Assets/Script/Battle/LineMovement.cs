using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement : MonoBehaviour
{
    private Image _line;
    public static bool[] lineCheck = new bool[7];
    public static bool[] dsl = new bool[7];
    public bool[] lineTrue = new bool[7];
    public static int _Count;
    private void Awake()
    {
        _line = GetComponent<Image>();
    }
    private void Update()
    {
        LineCkeck();
        dsl = ButtonStars._check;
    }

    private void LineCkeck()
    {
        if (ButtonStars._check[1] && ButtonStars._check[4] && gameObject.name == "Line0")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
            _Count++;
            lineCheck[gameObject.name[4] - 48] = true;
        }
        else if (ButtonStars._check[0] && ButtonStars._check[1] && gameObject.name == "Line1")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
            _Count++;
            lineCheck[gameObject.name[4] - 48] = true;
        }
        else if (ButtonStars._check[0] && ButtonStars._check[3] && gameObject.name == "Line2")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
            _Count++;
            lineCheck[gameObject.name[4] - 48] = true;
        }
        else if (ButtonStars._check[1] && ButtonStars._check[2] && gameObject.name == "Line3")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
            _Count++;
            lineCheck[gameObject.name[4] - 48] = true;
        }
        else if (ButtonStars._check[2] && ButtonStars._check[4] && gameObject.name == "Line4")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
            _Count++;
            lineCheck[gameObject.name[4] - 48] = true;
        }
        else if (ButtonStars._check[2] && ButtonStars._check[3] && gameObject.name == "Line5")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
            _Count++;
            lineCheck[gameObject.name[4] - 48] = true;
        }
        else if (ButtonStars._check[0] && ButtonStars._check[2] && gameObject.name == "Line6")
        {
            _line.color = Color.white;
            ButtonStars._check[ButtonStars.buttonCount] = false;
            _Count++;
            lineCheck[gameObject.name[4] - 48] = true;
        }
    }
}
