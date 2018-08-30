using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour {

    public GameObject[] waypoints;
    public int[] waypointsIndex;
    public GameObject player;
    public int turns;
    public TextMeshProUGUI winnerText;
    public GameObject finishMenu;
    public TextMeshProUGUI turnText;

    // Counts all waypoints and gets player's scripts
    void Start () {
        waypoints = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in waypoints);

    }

    // Checks how many turns player has left
    void Update () {

        turnText.text = "Turns: " + turns.ToString();

        if (turns <= 5)
        {
            turnText.color = Color.red;
        }
       if (turns <= 0)
        {
            finishMenu.SetActive(true);
            winnerText.text = "YOU LOSE";
        }
    }
}
