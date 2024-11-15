using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;
    public Vector3 cameraAngle;
    public Vector3 cameraOffset_2;
    public Vector3 cameraAngle_2;
    public PlayerController playerController;

    void Update()
    {
        if (playerController.checkpoint == 1 || playerController.checkpoint == 5)
        {
            transform.position = playerTransform.position + cameraOffset;
            transform.localEulerAngles = cameraAngle;
        }
        if (playerController.checkpoint >= 2 & playerController.checkpoint <= 4)
        {
            transform.position = playerTransform.position + cameraOffset_2;
            transform.localEulerAngles = cameraAngle_2;
        }
        
    }
}
