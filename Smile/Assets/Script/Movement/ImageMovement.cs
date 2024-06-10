using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageMovement : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites = new Sprite[6];
    private Image _Image;
    private void Awake()
    {
        _Image = GetComponent<Image>();
    }
    public void ImageCheck(int i)
    {
        _Image.sprite = _sprites[i];
    }
}
