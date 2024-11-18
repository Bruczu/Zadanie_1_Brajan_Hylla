using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItemController : MonoBehaviour
{
    public PlayerController playerController;
    public float speed;
    public bool isMovingUp = true;
    public bool spin;
    public Transform CollectibleTop;
    public Transform CollectibleBottom;
    /*
    public EndGameController endGameController;
    GameObject[] allCoins;
    void Start()
    {
        allCoins = GameObject.FindGameObjectsWithTag("Coin");
    }

    */


    void Update()
    {
        if (spin)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + 20 * Time.deltaTime, transform.localEulerAngles.z);
        }
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
        /*
        if (endGameController.wygrana == true)
        {
            this.gameObject.SetActive(true);
            Debug.Log("Zresetowano poziom");
            foreach (GameObject Coin in allCoins)
                Coin.SetActive(true);
            Debug.Log("zresetowano monety");
            endGameController.wygrana = false;
        }
        */
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.zebranePunkty++;
            //playerController.zebranePunkty= playerController.zebranePunkty + 12;
            Debug.Log("Zebrane Punkty: " + playerController.zebranePunkty);
            this.gameObject.SetActive(false);

            //Destroy(this.gameObject);
        }
    }
}
