using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public static Player instance;
    public int playerNumber;
    public float playerCurrency;
    public int index;
    public int areaIndex;
    public TextMeshProUGUI currencyText;
    public Manager manager;
    public string currentTile;
    public GameObject[] tiles;
    public TextMeshProUGUI finishText;
    public bool canMove;
    public int lettuces;
    public TextMeshProUGUI lettuceText;


    // Sets up player character
    void Awake()
    {
        lettuces = 3;
        tiles = GameObject.FindGameObjectsWithTag("Tile");
        instance = this;
        playerCurrency = 65;
    }

    // Shows how much currency player has on screen
    void Update()
    {
        lettuceText.text = "X" + lettuces.ToString();
        if (playerNumber == 1)
        {
            currencyText.color = Color.cyan;
        }

        currencyText.text = "Currency: " + playerCurrency.ToString();
    }

    // Records what tile the player is on and minus a turn
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tile")
        {
            index = other.GetComponent<TileNumber>().tileValue;
            currentTile = other.name;
            areaIndex = other.GetComponent<TileNumber>().tileArea;
        }
    }
}
