using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement : MonoBehaviour
{
    private Image _line;
    [SerializeField]private List<ButtonStars> _stars = new List<ButtonStars>(8);
    private void Awake()
    {
        _line = GetComponent<Image>();
    }
}
