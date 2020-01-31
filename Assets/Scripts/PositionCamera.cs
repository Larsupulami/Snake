using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCamera : MonoBehaviour
{
    private new Camera camera;
    private void Awake()
    {
        camera = GetComponent<Camera>();
        int halfX = Screen.width/2;
        int halfY = Screen.height/2;
        transform.position = new Vector3(halfX,halfY,-10);
        camera.orthographicSize = halfY;
    }
}
