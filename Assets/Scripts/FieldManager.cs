using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
}

public static class Field
{
    public static void Constructor(int stepSize)
    {
        resolution = new Vector2Int(Screen.width, Screen.height);
        StepSize = stepSize;
    }

    private static Vector2Int resolution;
    private static int stepSize;

    public static int StepSize
    {
        get => stepSize;
        private set
        {
            if (resolution.x % value != 0 || resolution.y % value > 0)
            {
                Debug.LogError($"{value} isn't compatible with that screen resolution.");
            }
        }
    }
}