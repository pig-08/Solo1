using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour
{
    private PatternMovement patternMovement;
    private void Awake()
    {
        patternMovement = FindObjectOfType<PatternMovement>();
        patternMovement.Canvas[gameObject.name[7] - 49] = gameObject;
    }
}
