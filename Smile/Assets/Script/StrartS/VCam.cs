using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCam : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
