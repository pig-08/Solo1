using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameImage : MonoBehaviour
{
    private HpMovemrnt _hpMovemrnt;
    private int _starsCount = 3;
    private int _haertCount = 2;
    private void Awake()
    {
        _hpMovemrnt = FindObjectOfType<HpMovemrnt>();
        _hpMovemrnt.images[gameObject.name[5] - 48] = GetComponent<Image>();
    }

    public void Stars()
    {
        _hpMovemrnt.images[_starsCount++].sprite = _hpMovemrnt.Stars;
    }

    public void Heart()
    {
        _hpMovemrnt.images[_haertCount--].sprite = _hpMovemrnt.Haert;
    }
}
