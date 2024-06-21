using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerEnemyHint : MonoBehaviour
{
    [SerializeField]private List<GameObject> hints;
    public static HintTextMovement[] _hintTextMovement = new HintTextMovement[3];

    public int EnemyCount { get; set; } = 0;
    public bool[] EnemyClick { get; set; } = new bool[5]; 

    private void Start()
    {
        foreach (var hint in hints)
        {
            hint.gameObject.SetActive(false);
        }
    }

    public void HintButtonSet(bool bools)
    {
        hints[1].SetActive(bools);
    }

    public void HintImageSet(bool bools)
    {
        hints[0].SetActive(bools);
    }
    public void HintButton()
    {
       if(EnemyCount == 0)
        {
            HintTextMovement.hint[0] = "";
            HintTextMovement.hint[1] = "";
            HintTextMovement.hint[2] = "";
            foreach (var hint in _hintTextMovement)
                hint.SetText();
        }
            hints[0].SetActive(true);
    }
}

