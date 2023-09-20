using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleInputController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
}
