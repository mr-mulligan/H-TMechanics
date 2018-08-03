using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject[] waypoints;
    public int[] waypointsIndex;

    // Use this for initialization
    void Start () {
        waypoints = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in waypoints);
        
    }

    // Update is called once per frame
    void Update () {

    }
}
