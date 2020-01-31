using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[System.Serializable]
public class DirectionEvent : UnityEvent<Vector2>
{
}

public class SnakePlayerInput : MonoBehaviour
{
    [SerializeField] private DirectionEvent directionEvent;

    private SnakeActions snakeActions;

    private void Awake()
    {
        snakeActions = new SnakeActions();
        snakeActions.Player.Move.performed += MoveOnPerformed;
    }


    private void MoveOnPerformed(InputAction.CallbackContext ctx) => directionEvent.Invoke(ctx.ReadValue<Vector2>());

    private void OnDisable() => snakeActions.Disable();

    private void OnEnable() => snakeActions.Enable();
}