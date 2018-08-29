using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class BackwardsTile : MonoBehaviour {

    public float playerSpeed = 0.5f;
    public Player player;
    public Manager manager;
    public TileNumber tilenumber;
    public TextMeshProUGUI costText;
    public PauseMenu pauseMenu;

    public int costTile;
    public int indexDifference;

    private Color startColor;

    // This will highlight tiles the player can move to
    // For now the movement is set at 1 per tile move
    void OnMouseEnter() {

        
            tilenumber = GetComponent<TileNumber>();
            startColor = GetComponent<Renderer>().material.color;

            costText.color = Color.green;
            CostOfTile();

        if (pauseMenu.isPaused == false)
        {
            if (Player.instance.currentTile.Contains("Tortoise"))
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.green;
            }

            // Change to red if tile is ahead of player
            if (Player.instance.index <= tilenumber.tileValue)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }

            if (Player.instance.areaIndex != tilenumber.tileArea)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
}

    // This will move the character to that tile on click
    // For now you can only move if you have more than 1 currency
    void OnMouseDown()
    {
        if (Player.instance.index > tilenumber.tileValue)
        {
            if (Player.instance.currentTile.Contains("Tortoise"))
            {
                return;
            }

            if (tilenumber.tileArea == Player.instance.areaIndex)
            {
                Player.instance.transform.DOMove(transform.position, playerSpeed).SetEase(Ease.InOutQuad).OnComplete(ArrivedOnTile);
            }
        }
    }

    // changes colour of tile back and clears cost text
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startColor;
        costText.text = "";
    }

    // Removes currency from player when they land on the tile, currently only takes away by 1
    void ArrivedOnTile()
    {
        Player.instance.playerCurrency += costTile;

    }

    // Works out the int difference between player and tile cursor is over and then takes the value from the PriceOfTiles index
    void CostOfTile()
    {
        indexDifference = tilenumber.tileValue - Player.instance.index;
       // Debug.Log(indexDifference);
        PriceOfTiles();
    }

    // Messy code but works properly - whatever the indexdifference is will set the amount player will earn going to the tile
    void PriceOfTiles()
    {
        // Easiest way to do the cost of the tiles that garaunteed to work properly

        if (indexDifference > 0)
        {
            costTile = 0;
        }
       if (indexDifference == -1)
        {
            costTile = 10;
        }

       if (indexDifference == -2)
        {
            costTile = 20;
        }

       if (indexDifference == -3)
        {
            costTile = 30;
        }

       if (indexDifference == -4)
        {
            costTile = 40;
        }

       if (indexDifference == -5)
        {
            costTile = 50;
        }

       if (indexDifference == -6)
        {
            costTile = 60;
        }

       if (indexDifference == -7)
        {
            costTile = 70;
        }
        costText.text = "+" + costTile.ToString();
    }
}

