using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement : MonoBehaviour
{
    private Image _line;
    public static bool[] lineCheck = new bool[7];
    public static int _Count;
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
        if (ButtonStars._check[1] && ButtonStars._check[4] && gameObject.name == "Line0")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line.color = Color.white;
                ButtonStars._check[ButtonStars.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                ButtonStars._check[ButtonStars.buttonCount] = false;
                print("tqlfk");
            }
        }
        else if (ButtonStars._check[0] && ButtonStars._check[1] && gameObject.name == "Line1")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line.color = Color.white;
                ButtonStars._check[ButtonStars.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                ButtonStars._check[ButtonStars.buttonCount] = false;
                print("tqlfk");
            }
        }
        else if (ButtonStars._check[0] && ButtonStars._check[3] && gameObject.name == "Line2")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line.color = Color.white;
                ButtonStars._check[ButtonStars.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                ButtonStars._check[ButtonStars.buttonCount] = false;
                print("tqlfk");
            }
        }
        else if (ButtonStars._check[1] && ButtonStars._check[2] && gameObject.name == "Line3")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line.color = Color.white;
                ButtonStars._check[ButtonStars.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                ButtonStars._check[ButtonStars.buttonCount] = false;
                print("tqlfk");
            }
        }
        else if (ButtonStars._check[2] && ButtonStars._check[4] && gameObject.name == "Line4")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line.color = Color.white;
                ButtonStars._check[ButtonStars.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                ButtonStars._check[ButtonStars.buttonCount] = false;
                print("tqlfk");
            }
        }
        else if (ButtonStars._check[2] && ButtonStars._check[3] && gameObject.name == "Line5")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line.color = Color.white;
                ButtonStars._check[ButtonStars.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                ButtonStars._check[ButtonStars.buttonCount] = false;
                print("tqlfk");
            }
        }
        else if (ButtonStars._check[0] && ButtonStars._check[2] && gameObject.name == "Line6")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line.color = Color.white;
                ButtonStars._check[ButtonStars.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                ButtonStars._check[ButtonStars.buttonCount] = false;
                print("tqlfk");
            }
        }
    }
}
