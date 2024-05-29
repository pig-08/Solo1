using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStars : MonoBehaviour
{
    private bool[] _check = new bool[5];
    private Button[] _stars = new Button[5];
    private void Awake()
    {
        _stars[0] = GameObject.Find("Stars").GetComponent<Button>();
        _stars[1] = GameObject.Find("Stars(1)").GetComponent<Button>();
        _stars[2] = GameObject.Find("Stars(2)").GetComponent<Button>();
        _stars[3] = GameObject.Find("Stars(3)").GetComponent<Button>();
        _stars[4] = GameObject.Find("Stars(4)").GetComponent<Button>();
        _stars[0].onClick.AddListener(() => ButtonCkeck(0));
        _stars[1].onClick.AddListener(() => ButtonCkeck(1));
        _stars[2].onClick.AddListener(() => ButtonCkeck(2));
        _stars[3].onClick.AddListener(() => ButtonCkeck(3));
        _stars[4].onClick.AddListener(() => ButtonCkeck(4));
    }
    public void ButtonCkeck(int i)
    {
        _check[i] = true;
    }

    private void LineCkeck()
    {

    }
}
