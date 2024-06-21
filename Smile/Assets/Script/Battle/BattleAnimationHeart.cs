using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAnimationHeart : MonoBehaviour
{
    private PatternMovement _patternMovement;
    private GameImage _gameImage;
    private void Start()
    {
        _patternMovement = FindObjectOfType<PatternMovement>();
        gameObject.SetActive(false);
        _gameImage = FindFirstObjectByType<GameImage>();
    }

    public void Heart()
    {
        gameObject.SetActive(true);
        StartCoroutine(HeartTime());
    }

    private IEnumerator HeartTime()
    {
        yield return new WaitForSeconds(0.4f);
        _gameImage.Heart();
        gameObject.SetActive(false);
        _patternMovement.PatternCheck();
    }
}
