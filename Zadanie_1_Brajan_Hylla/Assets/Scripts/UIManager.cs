using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public PlayerController playerController;
    public TextMeshProUGUI text;
    public EndGameController endGameController;
    
    void Update()
    {
        text.text = playerController.zebranePunkty.ToString();

        if (playerController.zebranePunkty ==  endGameController.iloscPunktowDoZebrania)
        {
            text.color = Color.green;
        }
    }
}
