using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStars : MonoBehaviour
{
    private Button _stars;
    private LineMovement _lineMovement;
    public static bool[] _check = new bool[5];
    private static int _count;
    public static int buttonCount;
    private void Awake()
    {
        _stars =GetComponent<Button>();
        _stars.onClick.AddListener(() => ButtonCkeck((gameObject.name[5])));
    }
    public void ButtonCkeck(int i)
    {
        i -= 48;
        _check[i] = true;
        ++_count;
        if (_count == 1)
            buttonCount = i;
        else if(_count == 2)
            _count = 0;
    }
}
