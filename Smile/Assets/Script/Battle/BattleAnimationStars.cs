using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAnimationStars : MonoBehaviour
{
    private PatternMovement _patternMovement;
    private GameImage _gameImage;
    private void Start()
    {
        _patternMovement = FindObjectOfType<PatternMovement>();
        _gameImage = FindObjectOfType<GameImage>();
        gameObject.SetActive(false);
    }
    
    public void Statrs()
    {
        gameObject.SetActive(true);
        StartCoroutine(StatrTime());
    }

    private IEnumerator StatrTime()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
        _patternMovement.PatternCheck();
        _gameImage.Stars();
    }
}
