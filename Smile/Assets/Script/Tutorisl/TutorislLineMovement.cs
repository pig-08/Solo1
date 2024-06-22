using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorislLineMovement : MonoBehaviour
{
    private static Image[] _line = new Image[2];
    private static bool[] lineCheck = new bool[2];
    private static bool[] lineCheckCount = new bool[2];
    public static int _Count;
    public bool[] fyjydf= new bool[3];
    [SerializeField] private GameObject _gameObject;
    private ButtonMovement _buttonMovement;
    private static bool n;

    private void Awake()
    {
        _line[gameObject.name[4] - 48] = GetComponent<Image>();
        _line[gameObject.name[4] - 48].color = Color.gray;
        _buttonMovement = FindObjectOfType<ButtonMovement>();
    }
    private void Update()
    {
        fyjydf = TutorislButtonStars._check;
        LineCkeck();
        if (TutorislButtonStars.battleChecl)
        {
            for (int i = 0; i < TutorislButtonStars._check.Length; i++)
                TutorislButtonStars._check[i] = false;
            foreach (Button item in TutorislButtonStars._stars)
                item.interactable = true;
            foreach (Image line in _line)
                line.color = Color.gray;
            for (int i = 0; i < lineCheck.Length; i++)
                lineCheck[i] = false;
            for (int i = 0; i < lineCheckCount.Length; i++)
                lineCheckCount[i] = false;
            _Count = 0;
            TutorislButtonStars.battleChecl = false;
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
            _buttonMovement.Window(true);
        }
        else
        {
            if (TutorislButtonStars._check[0] && TutorislButtonStars._check[2] && gameObject.name == "Line0")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    TutorislButtonStars._check[TutorislButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    n = true;
                    if(n)
                    {
                        for (int i = 0; i < TutorislButtonStars._check.Length; i++) TutorislButtonStars._check[i] = false;
                        TutorislButtonStars.battleChecl = true;
                        _gameObject.SetActive(false);
                        n = false;
                        _gameObject.SetActive(true);
                    }
                }
            }
            else if (TutorislButtonStars._check[1] && TutorislButtonStars._check[2] && gameObject.name == "Line1")
            {
                if (!lineCheck[gameObject.name[4] - 48])
                {
                    _line[gameObject.name[4] - 48].color = Color.white;
                    TutorislButtonStars._check[TutorislButtonStars.buttonCount] = false;
                    lineCheck[gameObject.name[4] - 48] = true;
                    lineCheckCount[gameObject.name[4] - 48] = true;
                }
                else
                {
                    n = true;
                    if (n)
                    {
                        for (int i = 0; i < TutorislButtonStars._check.Length; i++) TutorislButtonStars._check[i] = false;
                        TutorislButtonStars.battleChecl = true;
                        _gameObject.SetActive(false);
                        n = false;
                        _gameObject.SetActive(true);
                    }
                }
            }
        }
    }
}
