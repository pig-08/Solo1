using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStars5 : MonoBehaviour
{
    public static Button[] _stars = new Button[8];
    public static bool[] _check = new bool[8];
    public static bool[] _starsCheck = new bool[8];
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
            item.interactable = true;
        if (j.name == "Stars0")
        {//2.5»©°í´Ù
            _stars[1].interactable = false;
            _stars[3].interactable = false;
            _stars[4].interactable = false;
            _stars[6].interactable = false;
            _stars[7].interactable = false;
        }
        else if (j.name == "Stars1")
        {//6.4»©°í´Ù
            _stars[0].interactable = false;
            _stars[2].interactable = false;
            _stars[3].interactable = false;
            _stars[5].interactable = false;
            _stars[7].interactable = false;
        }
        else if (j.name == "Stars2")
        {//6.0•û°í´Ù
            _stars[1].interactable = false;
            _stars[3].interactable = false;
            _stars[4].interactable = false;
            _stars[5].interactable = false;
            _stars[7].interactable = false;
        }
        else if (j.name == "Stars3")
        {//5.6.7»©°í´Ù
            _stars[1].interactable = false;
            _stars[2].interactable = false;
            _stars[4].interactable = false;
        }
        else if (j.name == "Stars4")
        {//1.5•û°í´Ù
            _stars[0].interactable = false;
            _stars[2].interactable = false;
            _stars[3].interactable = false;
            _stars[6].interactable = false;
            _stars[7].interactable = false;
        }
        else if (j.name == "Stars5")
        {//6.1.2¾Èº¸ÀÓ
            _stars[1].interactable = false;
            _stars[6].interactable = false;
            _stars[2].interactable = false;
        }
        else if (j.name == "Stars6")
        {//5.4.0¾Èº¸ÀÓ
            _stars[0].interactable = false;
            _stars[4].interactable = false;
            _stars[5].interactable = false;
        }
        else if (j.name == "Stars7")
        {//6.3.5»©°í´Ù
            _stars[1].interactable = false;
            _stars[2].interactable = false;
            _stars[4].interactable = false;
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
