using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMovement : MonoBehaviour
{
    public GameObject[] Canvas{ private set; get; } = new GameObject[7];
    public static bool Linecolor;
    private int _click = 9999;
    private int _intcount = 999;
    private int _count = 0;
    private void Start()
    {
        foreach (GameObject item in Canvas)
        {
            item.SetActive(false);
        }
        PatternCheck();
    }
    public void PatternCheck()
    {
        int i = Random.Range(0, Canvas.Length);
        while (true)
        {
            if (_click == i || _intcount == i)
            {
                i = Random.Range(0, Canvas.Length);
            }
            else
            {
                Linecolor = true;
                if(_count < 2)_count++;
                else if (_count == 2)_intcount = _click;
                _click = i;
                Canvas[i].SetActive(true);
                break;
            }
        }
    }

    public void SetActiveFalse()
    {
        foreach (GameObject item in Canvas)
        {
            item.SetActive(false);
        }
    }
}

