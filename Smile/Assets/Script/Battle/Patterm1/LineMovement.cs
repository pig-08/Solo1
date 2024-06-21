using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement : MonoBehaviour
{
    private static Image[] _line = new Image[7];
    private PatternMovement _patternMovement;
    private static bool[] lineCheck = new bool[7];
    private static bool[] lineCheckCount = new bool[7];
    public static int _Count;
    private BattleAnimationHeart _battleAnimationHeart;
    private BattleAnimationStars _battleAnimationStars;

    private void Awake()
    {
        _line[gameObject.name[4] - 48] = GetComponent<Image>();
        _patternMovement = FindObjectOfType<PatternMovement>();
        _line[gameObject.name[4] - 48].color = Color.gray;
        _battleAnimationHeart = FindObjectOfType<BattleAnimationHeart>();
        _battleAnimationStars = FindObjectOfType<BattleAnimationStars>();
    }
    private void Update()
    {
        LineCkeck();
        if (PatternMovement.Linecolor)
        {
            for (int i = 0; i < ButtonStars._check.Length; i++)
                ButtonStars._check[i] = false;
            foreach (Button item in ButtonStars._stars)
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
        for(int i = 0; i < lineCheck.Length; i++)
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
        if(_Count == lineCheck.Length)
        {
            for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
            _patternMovement.SetActiveFalse();
            _battleAnimationStars.Statrs();
            _Count = 0;
        }
        else
        {
            if (ButtonStars._check[1] && ButtonStars._check[4] && gameObject.name == "Line0")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars._check[ButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars._check[0] && ButtonStars._check[1] && gameObject.name == "Line1")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars._check[ButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars._check[0] && ButtonStars._check[3] && gameObject.name == "Line2")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars._check[ButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars._check[1] && ButtonStars._check[2] && gameObject.name == "Line3")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars._check[ButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars._check[2] && ButtonStars._check[4] && gameObject.name == "Line4")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars._check[ButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars._check[2] && ButtonStars._check[3] && gameObject.name == "Line5")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars._check[ButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars._check[0] && ButtonStars._check[2] && gameObject.name == "Line6")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars._check[ButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars._check.Length; i++) ButtonStars._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
        }
    }
}
