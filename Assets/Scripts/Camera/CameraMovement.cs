using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Vector3 initialCamera;

    [SerializeField]
    string CameraTarget = "Clunk_shooting";

    private void Start()
    {
        player = GameObject.Find(CameraTarget);
        initialCamera = Camera.main.transform.position;
    }

    private void Update()
    {
        transform.position = player.transform.position + new Vector3(initialCamera.x, initialCamera.y, initialCamera.z);
    }
}
