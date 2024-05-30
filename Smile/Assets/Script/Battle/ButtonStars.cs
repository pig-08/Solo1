using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStars : MonoBehaviour
{
    [SerializeField]private bool[] _check = new bool[5];
    private Button _stars;
    private void Awake()
    {
        _stars =GetComponent<Button>();
        _stars.onClick.AddListener(() => ButtonCkeck((gameObject.name[5])));
    }
    public void ButtonCkeck(int i)
    {
        i -= 48;
        _check[i] = true;
    }
}
