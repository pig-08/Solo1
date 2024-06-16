using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMovement : MonoBehaviour
{
    public GameObject[] Canvas{ private set; get; } = new GameObject[7];
    public static bool Linecolor;
    private int _click = 9999;
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
            if(_click == i)
                i = Random.Range(0, Canvas.Length);
            else
            {
                Linecolor = true;
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

