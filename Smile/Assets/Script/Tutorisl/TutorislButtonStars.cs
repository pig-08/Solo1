using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorislButtonStars : MonoBehaviour
{
    public static Button[] _stars = new Button[3];
    public static bool[] _check = new bool[3];
    public static bool battleChecl; 
    public static int buttonCount;
    private static int _clickCount;
    private static int _startCount;
    private static int _endCount;
    private void Awake()
    {
        _stars[gameObject.name[5] - 48] = GetComponent<Button>();
        _stars[gameObject.name[5] - 48].onClick.AddListener(() => ButtonCkeck(gameObject.name[5],gameObject));
    }
    private void ButtonCkeck(int i,GameObject j)
    {
        i -= 48;
        foreach (Button item in _stars)
        {
            item.interactable = true;
        }
        if (j.name == "Stars0")
        {
            _stars[1].interactable = false;
        }
        else if (j.name == "Stars1")
        {
            _stars[0].interactable = false;
        }
        if (_clickCount == 0)
        {
            _check[i] = true;
            ++_clickCount;
            buttonCount = i;
        }
        else if (_clickCount == 1)
        {
            _check[i] = true;
            if (_startCount == 0)
            {
                _endCount = i;
                _startCount = 1;
            }
            else if (_startCount >= 1)
            {
                buttonCount = _endCount;
                _endCount = i;
            }
        }
    }
}