using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement5 : MonoBehaviour
{
    private static Image[] _line = new Image[11];
    private PatternMovement _patternMovement;
    private static bool[] lineCheck = new bool[11];
    private static bool[] lineCheckCount = new bool[11];
    private static int _Count;
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
            for (int i = 0; i < ButtonStars5._check.Length; i++)
                ButtonStars5._check[i] = false;
            foreach (Button item in ButtonStars5._stars)
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
        for (int i = 0; i < lineCheck.Length; i++)
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
        if (_Count == lineCheck.Length)
        {
            for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
            _patternMovement.SetActiveFalse();
            _battleAnimationStars.Statrs();
            _Count = 0;
        }
        else
        {
            if (ButtonStars5._check[0] && ButtonStars5._check[2] && gameObject.name == "Line9")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }

            }
            else if (ButtonStars5._check[0] && ButtonStars5._check[5] && gameObject.name == "Line3")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            if (ButtonStars5._check[1] && ButtonStars5._check[4] && gameObject.name == "Line0")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart ();
                }

            }
            else if (ButtonStars5._check[1] && ButtonStars5._check[6] && gameObject.name == "Line1")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars5._check[2] && ButtonStars5._check[6] && gameObject.name == "Line8")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars5._check[3] && ButtonStars5._check[6] && gameObject.name == "Line4")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars5._check[3] && ButtonStars5._check[5] && gameObject.name == "Line5")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars5._check[3] && ButtonStars5._check[7] && gameObject.name == "Line:(10)")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars5._check[4] && ButtonStars5._check[5] && gameObject.name == "Line2")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars5._check[5] && ButtonStars5._check[7] && gameObject.name == "Line7")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
            else if (ButtonStars5._check[6] && ButtonStars5._check[7] && gameObject.name == "Line6")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    ButtonStars5._check[ButtonStars5.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    for (int i = 0; i < ButtonStars5._check.Length; i++) ButtonStars5._check[i] = false;
                    _patternMovement.SetActiveFalse();
                    _battleAnimationHeart.Heart();
                }
            }
        }
    }
}