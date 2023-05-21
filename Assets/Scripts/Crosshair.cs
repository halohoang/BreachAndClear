using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    // Variables

    // Functions
    void Awake()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector2 _mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        transform.position = _mouseCursorPos;
    }
}
