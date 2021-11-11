using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Vector3 initialCamera;

    private void Start()
    {
        player = GameObject.Find("Clunk_shooting");
        initialCamera = Camera.main.transform.position;
    }

    private void Update()
    {
        transform.position = player.transform.position + new Vector3(initialCamera.x, initialCamera.y, initialCamera.z);
    }
}
