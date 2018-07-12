using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player instance;
    public float playerCurrency;

    // Sets up player character
    void Awake()
    {
        instance = this;
        playerCurrency = 65;
    }
}
