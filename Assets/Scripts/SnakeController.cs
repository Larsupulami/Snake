using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.EventSystems;


public class SnakeController : MonoBehaviour
{
    [SerializeField, ReadOnly] private MoveDirection moveDirection = MoveDirection.Right;

    public void ChangeMoveDirection(Vector2 direction)
    {
        if (direction.y > 0) moveDirection = MoveDirection.Up;
        else if (direction.y < 0) moveDirection = MoveDirection.Down;

        if (direction.x > 0) moveDirection = MoveDirection.Right;
        else if (direction.x < 0) moveDirection = MoveDirection.Left;
    }
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}