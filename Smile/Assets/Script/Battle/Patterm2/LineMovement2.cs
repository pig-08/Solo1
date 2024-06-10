using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement2 : MonoBehaviour
{
    private static Image[] _line = new Image[9];
    private PatternMovement _patternMovement;
    private static bool[] lineCheck = new bool[9];
    private static bool[] lineCheckCount = new bool[9];
    private static int _Count;

    private void Awake()
    {
        _line[gameObject.name[4] - 48] = GetComponent<Image>();
        _patternMovement = FindObjectOfType<PatternMovement>();
        _line[gameObject.name[4] - 48].color = Color.gray;
    }
    private void Update()
    {
        LineCkeck();
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
            for (int i = 0; i < lineCheckCount.Length; i++)
                lineCheckCount[i] = false;
            _Count = 0;
            PatternMovement.Linecolor = false;
        }
        for (int i = 0; i < lineCheck.Length; i++)
        {
            if (lineCheckCount[i])
            {
                _Count++;
                lineCheckCount[i] = false;
            }
        }
    }

    private void LineCkeck()
    {
        if (_Count == lineCheck.Length)
        {
            print("����!");
            _Count = 0;
            _patternMovement.SetActiveFalse();
            _patternMovement.PatternCheck();
        }
        else
        {
            if (ButtonStars2._check[0] && ButtonStars2._check[2] && gameObject.name == "Line5")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars2._check[ButtonStars2.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
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
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    _patternMovement.SetActiveFalse();
                    _patternMovement.PatternCheck();
                }
            }
        }
    }
}