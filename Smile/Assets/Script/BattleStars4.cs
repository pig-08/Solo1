using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStars4 : MonoBehaviour
{
    [SerializeField]private bool _check;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetButtonDown("Fire1"))
        {
            _check = true;
        }
    }
}
