using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FinishTile : MonoBehaviour {

    public float playerSpeed = 0.5f;
    public Player player;
    public Manager manager;

    private Color startColor;

    // This will highlight tiles the player can move to
    // For now the movement is set at 1 per tile move
    void OnMouseEnter()
    {
        if (Player.instance.playerCurrency >= 1)
        {
            startColor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
        }


    }
    // This will move the character to that tile on click
    // For now you can only move if you have more than 1 currency
    void OnMouseDown()
    {
        if (Player.instance.playerCurrency >= 1)
        {

            Player.instance.transform.DOMove(transform.position, playerSpeed).SetEase(Ease.InOutQuad).OnComplete(ArrivedOnTile);
        }
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startColor;
    }

    // Currently restarts game
    void ArrivedOnTile()
    {
        SceneManager.LoadScene("Debug 2D Scene");
             
    }
}

