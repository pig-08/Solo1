using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private Camera m_Camera;
    private void Awake()
    {
        m_Camera = Camera.main;
    }
    private void Update()
    {
        Vector2 mouseVector = m_Camera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseVector;
    }


}
