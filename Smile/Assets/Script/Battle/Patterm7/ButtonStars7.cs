using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStars7 : MonoBehaviour
{
    public static Button[] _stars = new Button[10];
    public static bool[] _check = new bool[10];
    public static bool[] _starsCheck = new bool[10];
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
        {//4.5.9.2
            _stars[1].interactable = false;
            _stars[6].interactable = false;
            _stars[7].interactable = false;
            _stars[8].interactable = false;
        }
        else if (j.name == "Stars1")
        {//5.2.3
            _stars[0].interactable = false;
            _stars[4].interactable = false;
            _stars[3].interactable = false;
            _stars[6].interactable = false;
            _stars[7].interactable = false;
            _stars[8].interactable = false;
            _stars[9].interactable = false;
        }
        else if (j.name == "Stars2")
        {//6.0.1.4
            _stars[5].interactable = false;
            _stars[7].interactable = false;
            _stars[8].interactable = false;
            _stars[9].interactable = false;
        }
        else if (j.name == "Stars3")
        {//1.9
            _stars[1].interactable = false;
            _stars[4].interactable = false;
            _stars[5].interactable = false;
            _stars[6].interactable = false;
            _stars[7].interactable = false;
            _stars[8].interactable = false;
            _stars[9].interactable = false;
        }
        else if (j.name == "Stars4")
        {//1.3.9
            _stars[1].interactable = false;
            _stars[3].interactable = false;
            _stars[9].interactable = false;
            _stars[5].interactable = false;
            _stars[6].interactable = false;
        }
        else if (j.name == "Stars5")
        {//0.1.6.7
            _stars[2].interactable = false;
            _stars[3].interactable = false;
            _stars[4].interactable = false;
            _stars[8].interactable = false;
            _stars[9].interactable = false;
        }
        else if (j.name == "Stars6")
        {//2.5.8.9
            _stars[0].interactable = false;
            _stars[1].interactable = false;
            _stars[3].interactable = false;
            _stars[4].interactable = false;
            _stars[7].interactable = false;
        }
        else if (j.name == "Stars7")
        {//4.5.
            _stars[0].interactable = false;
            _stars[1].interactable = false;
            _stars[2].interactable = false;
            _stars[3].interactable = false;
            _stars[6].interactable = false;
            _stars[8].interactable = false;
            _stars[9].interactable = false;
        }
        else if (j.name == "Stars8")
        {//6.4
            _stars[1].interactable = false;
            _stars[2].interactable = false;
            _stars[3].interactable = false;
            _stars[5].interactable = false;
            _stars[7].interactable = false;
            _stars[9].interactable = false;
            _stars[0].interactable = false;
        }
        else if (j.name == "Stars9")
        {//0.6
            _stars[1].interactable = false;
            _stars[2].interactable = false;
            _stars[3].interactable = false;
            _stars[4].interactable = false;
            _stars[5].interactable = false;
            _stars[7].interactable = false;
            _stars[8].interactable = false;
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
