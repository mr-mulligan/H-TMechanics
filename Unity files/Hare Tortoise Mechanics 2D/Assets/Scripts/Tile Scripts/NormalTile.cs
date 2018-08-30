using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class CarrotTile : MonoBehaviour {


    public float playerSpeed = 0.5f;
    public Player player;
    public Manager manager;
    public TileNumber tilenumber;
    public TextMeshProUGUI costText;

    public int costTile;
    public int indexDifference;
    public PauseMenu pauseMenu;

    private Color startColor;

    private void Awake()
    {
        costText.text = "";
        pauseMenu.GetComponent<PauseMenu>();
        tilenumber = GetComponent<TileNumber>();
    }

    void Update()
    {
        
    }
    // This will highlight tiles the player can move to and will lead to calculating how much it will cost the player
    void OnMouseEnter()
    {
      
            tilenumber = GetComponent<TileNumber>();
            startColor = GetComponent<Renderer>().material.color;

            costText.color = Color.red;
            CostOfTile();
        if (pauseMenu.isPaused == false)
        {
            // If player can afford tile, it will go green, if not then red
            if (Player.instance.playerCurrency >= costTile)
            {

                GetComponent<Renderer>().material.color = new Color32(100, 255, 100, 255);

            }
            else
            {
                GetComponent<Renderer>().material.color = Color.red;
            }

            // Will also change colour of tile to red as well if its behind the player to indicate you cannot move to it
            if (Player.instance.index >= tilenumber.tileValue)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }

    // This will move the character to that tile on click if you can afford the tile
    void OnMouseDown()
    {
        if (Player.instance.playerCurrency >= costTile)
        {
            if (Player.instance.index < tilenumber.tileValue)
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

    // Removes currency from player when they land on the tile by whatever the cost of the tile is
    void ArrivedOnTile()
    {
        
        Player.instance.playerCurrency -= costTile;
        manager.turns--;

    }

    // Works out the int difference between player and tile cursor is over and then takes the value from the PriceOfTiles index
    void CostOfTile()
    {
        indexDifference = tilenumber.tileValue - Player.instance.index;
        PriceOfTiles();
        //Debug.Log(indexDifference);
    }

    // Messy code but works properly - whatever the indexdifference is will set the cost of the tile
   void PriceOfTiles()
    { 
        // Easiest way to make each price for each tile that was garaunteed to work
        if (indexDifference == 1)
        {
            costTile = 1;
        }

        if (indexDifference == 2)
        {
            costTile = 3;
        }

        if (indexDifference == 3)
        {
            costTile = 6;
        }

        if (indexDifference == 4)
        {
            costTile = 10;
        }

        if (indexDifference == 5)
        {
            costTile = 15;
        }

        if (indexDifference == 6)
        {
            costTile = 21;
        }

        if (indexDifference == 7)
        {
            costTile = 28;
        }

        if (indexDifference == 8)
        {
            costTile = 36;
        }

        if (indexDifference == 9)
        {
            costTile = 45;
        }

        if (indexDifference == 10)
        {
            costTile = 55;
        }

        if (indexDifference == 11)
        {
            costTile = 66;
        }

        if (indexDifference == 12)
        {
            costTile = 78;
        }

        if (indexDifference == 13)
        {
            costTile = 91;
        }

        if (indexDifference == 14)
        {
            costTile = 105;
        }

        if (indexDifference == 15)
        {
            costTile = 120;
        }

        if (indexDifference == 16)
        {
            costTile = 136;
        }

        if (indexDifference == 17)
        {
            costTile = 153;
        }

        if (indexDifference == 18)
        {
            costTile = 171;
        }

        if (indexDifference == 19)
        {
            costTile = 190;
        }

        if (indexDifference == 20)
        {
            costTile = 210;
        }

        if (indexDifference == 21)
        {
            costTile = 231;
        }

        if (indexDifference == 22)
        {
            costTile = 253;
        }

        if (indexDifference == 23)
        {
            costTile = 276;
        }

        if (indexDifference == 24)
        {
            costTile = 300;
        }

        if (indexDifference == 25)
        {
            costTile = 325;
        }

        if (indexDifference == 26)
        {
            costTile = 351;
        }

        if (indexDifference == 27)
        {
            costTile = 378;
        }

        if (indexDifference == 28)
        {
            costTile = 406;
        }

        if (indexDifference == 29)
        {
            costTile = 435;
        }

        if (indexDifference == 30)
        {
            costTile = 465;
        }

        if (indexDifference == 31)
        {
            costTile = 496;
        }

        if (indexDifference == 32)
        {
            costTile = 528;
        }

        if (indexDifference == 33)
        {
            costTile = 561;
        }

        if (indexDifference == 34)
        {
            costTile = 595;
        }

        if (indexDifference == 35)
        {
            costTile = 630;
        }

        if (indexDifference == 36)
        {
            costTile = 666;
        }

        if (indexDifference == 37)
        {
            costTile = 703;
        }

        if (indexDifference == 38)
        {
            costTile = 741;
        }

        if (indexDifference == 39)
        {
            costTile = 780;
        }

        if (indexDifference == 40)
        {
            costTile = 820;
        }
        if (indexDifference > 40)
        {
            costTile = 9999;
        }
        costText.text = "-" + costTile.ToString();
    }
}

