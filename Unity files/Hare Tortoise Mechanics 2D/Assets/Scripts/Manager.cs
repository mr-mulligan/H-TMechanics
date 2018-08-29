using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject[] waypoints;
    public int[] waypointsIndex;
    public GameObject player;
    public int playerActive;

    // Counts all waypoints and gets player's scripts
    void Start () {
        waypoints = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in waypoints);

    }

    // Sets which player is active
    void Update () {
       
    }
}
