using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtorislcCheckM : MonoBehaviour
{
    public int EnemyCount { get; set; }
    public int DeathCount { get; set; }
    public int LineFailCount { get; set; }
    public int LineSuccessCount { get; set; }
    
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
