using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItemController : MonoBehaviour
{
    public PlayerController playerController;
    public float speed;
    public bool isMovingUp = true;
    public Transform CollectibleTop;
    public Transform CollectibleBottom;

    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + 20 * Time.deltaTime, transform.localEulerAngles.z);

        if (isMovingUp)
        {
            transform.Translate(0, 1 * Time.deltaTime * speed, 0);
            if (transform.position.y > CollectibleTop.position.y)
            {
                isMovingUp = false;
            }
        }
        else
        {
            transform.Translate(0, - 1 * Time.deltaTime * speed, 0);
            if (transform.position.y < CollectibleBottom.position.y)
            {
                isMovingUp = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.zebranePunkty++;
            Debug.Log("Zebrane Punkty: " + playerController.zebranePunkty);
            Destroy(this.gameObject);
        }
    }
}
