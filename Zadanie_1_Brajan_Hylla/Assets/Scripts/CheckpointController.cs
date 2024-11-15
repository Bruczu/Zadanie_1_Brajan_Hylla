using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public PlayerController playerController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.checkpoint++;
            Debug.Log(playerController.checkpoint);
            Destroy(this.gameObject);
        }
    }
}

