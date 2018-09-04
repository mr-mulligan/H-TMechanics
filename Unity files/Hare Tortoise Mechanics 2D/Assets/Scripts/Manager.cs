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
    public GameObject difficultyObject;
    public Difficulty difficultyScript;

    // Counts all waypoints and gets player's scripts
    void Start () {
        waypoints = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in waypoints);
        difficultyObject = GameObject.FindGameObjectWithTag("difficulty");
        difficultyScript = difficultyObject.GetComponent<Difficulty>();
        DifficultySet();

    }


    void Update () {

        // Checks how many turns player has left
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

   void DifficultySet()
    {
        // Sets the difficulty of the game
        if (difficultyScript.difficultyInt == 0)
        {
            turns = UnityEngine.Random.Range(44, 51); 
        }

        if (difficultyScript.difficultyInt == 1)
        {
            turns = UnityEngine.Random.Range(34, 41);
        }

        if (difficultyScript.difficultyInt == 2)
        {
            turns = UnityEngine.Random.Range(24, 31);
        }
    }

}
