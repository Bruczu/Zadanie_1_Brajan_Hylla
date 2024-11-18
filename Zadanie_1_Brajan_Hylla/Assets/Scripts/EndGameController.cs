using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    public PlayerController playerController;
    public int iloscPunktowDoZebrania;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerController.zebranePunkty == iloscPunktowDoZebrania)
            {
                Debug.Log("Zebra³eœ wszystkie punkty oraz pokona³eœ tor przeszkód! Brawo, wygra³eœ! Koniec gry.");
            }
        }
    }
    

}
