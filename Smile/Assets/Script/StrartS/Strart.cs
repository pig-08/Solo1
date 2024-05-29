using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Strart : MonoBehaviour
{
    private PlayerAnimation _playerAnimation;

    private void Awake()
    {
        _playerAnimation = GameObject.FindObjectOfType<PlayerAnimation>();
    }
    public void PLAY()
    {
        SceneManager.LoadScene("FirstFloor");
    }

    private IEnumerator Time()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
