using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BackwardsTile : MonoBehaviour {

    public float playerSpeed = 0.5f;
    public Player player;
    public Manager manager;
    public TileNumber tilenumber;

    private Color startColor;

    // This will highlight tiles the player can move to
    // For now the movement is set at 1 per tile move
    void OnMouseEnter() {

        tilenumber = GetComponent<TileNumber>();
        startColor = GetComponent<Renderer>().material.color;

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
            else
            {
            Player.instance.transform.DOMove(transform.position, playerSpeed).SetEase(Ease.InOutQuad).OnComplete(ArrivedOnTile);
            }

        }
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startColor;
    }

    // Removes currency from player when they land on the tile, currently only takes away by 1
    void ArrivedOnTile()
    {
        Player.instance.playerCurrency += 10;

    }
}

