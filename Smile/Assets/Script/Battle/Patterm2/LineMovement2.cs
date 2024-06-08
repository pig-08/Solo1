using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement2 : MonoBehaviour
{
    [SerializeField]private static Image[] _line = new Image[9];
    private PatternMovement _patternMovement;
    public static bool[] lineCheck = new bool[9];
    public static int _Count;
    private void Awake()
    {
        _line[gameObject.name[4] - 48] = GetComponent<Image>();
        _patternMovement = FindObjectOfType<PatternMovement>();
        _line[gameObject.name[4] - 48].color = Color.gray;
    }
    private void Update()
    {
        if (PatternMovement.Linecolor)
        {
            for (int i = 0; i < ButtonStars2._check.Length; i++)
                ButtonStars2._check[i] = false;
            foreach (Button item in ButtonStars2._stars)
                item.interactable = true;
            foreach (Image line in _line)
                line.color = Color.gray;
            for (int i = 0; i < lineCheck.Length; i++)
                lineCheck[i] = false;
            PatternMovement.Linecolor = false;
        }
        LineCkeck();
    }

    private void LineCkeck()
    {
        if (ButtonStars2._check[0] && ButtonStars2._check[2] && gameObject.name == "Line5")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }

        }
        else if (ButtonStars2._check[0] && ButtonStars2._check[3] && gameObject.name == "Line1")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
        else if (ButtonStars2._check[1] && ButtonStars2._check[2] && gameObject.name == "Line3")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
        else if (ButtonStars2._check[1] && ButtonStars2._check[5] && gameObject.name == "Line0")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
        else if (ButtonStars2._check[2] && ButtonStars2._check[5] && gameObject.name == "Line8")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
        else if (ButtonStars2._check[2] && ButtonStars2._check[3] && gameObject.name == "Line7")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
        else if (ButtonStars2._check[3] && ButtonStars2._check[5] && gameObject.name == "Line2")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
        else if (ButtonStars2._check[3] && ButtonStars2._check[4] && gameObject.name == "Line4")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
        else if (ButtonStars2._check[5] && ButtonStars2._check[4] && gameObject.name == "Line6")
        {
            if (!lineCheck[gameObject.name[4] - 48])
            {
                _line[gameObject.name[4] - 48].color = Color.white;
                ButtonStars2._check[ButtonStars2.buttonCount] = false;
                _Count++;
                lineCheck[gameObject.name[4] - 48] = true;
            }
            else
            {
                _patternMovement.SetActiveFalse();
                _patternMovement.PatternCheck();
            }
        }
    }
}
