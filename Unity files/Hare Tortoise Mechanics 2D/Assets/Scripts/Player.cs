using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static Player instance;
    public float playerCurrency;
    public Text currencyText;
    public string currentTile;


    // Sets up player character
    void Awake()
    {

        instance = this;
        playerCurrency = 65;
    }

    // Shows how much currency player has on screen
    void Update()
    {
        currencyText.text = "Currency: " + playerCurrency.ToString();
    }

    // Records what tile the player is on
    // Trying to make waypointindex increase based on what tile player is on
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tile")
        {
            currentTile = other.name;
            Debug.Log("Tile is " + other.name);
        }
    }
}
