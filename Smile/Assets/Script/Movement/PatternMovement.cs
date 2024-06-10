using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMovement : MonoBehaviour
{
    public GameObject[] Canvas{ private set; get; } = new GameObject[3];
    public static bool Linecolor;
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
        Linecolor = true;
        Canvas[i].SetActive(true);
    }

    public void SetActiveFalse()
    {
        foreach (GameObject item in Canvas)
        {
            item.SetActive(false);
        }
    }
}

