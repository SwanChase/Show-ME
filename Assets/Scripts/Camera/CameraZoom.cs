using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] float speedZoom;
    [SerializeField] float minCameraSize, maxCameraSize;

    void Update()
    {
        zoomControl();
    }

    private void zoomControl()
    {
        if (Camera.main.orthographicSize - Input.mouseScrollDelta.y >= minCameraSize && Camera.main.orthographicSize - Input.mouseScrollDelta.y <= maxCameraSize)
        {
            Camera.main.orthographicSize -= Input.mouseScrollDelta.y * speedZoom;
        }
    }
}
