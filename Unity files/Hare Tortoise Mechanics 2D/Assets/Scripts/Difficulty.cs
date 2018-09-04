using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Difficulty : MonoBehaviour {

    public GameObject dropdownBox;
    public TMP_Dropdown dropdown;
    public GameObject DifficultyObject;
    public Vector3 Location;
    public int difficultyInt;
    public bool Created;

    // Checks to see if the object is there
    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // Checks integer value
    public void Update()
    {

        dropdownBox = GameObject.Find("Dropdown");
        dropdown = dropdownBox.GetComponent<TMP_Dropdown>();

        if (dropdown != null)
        {

        difficultyInt = dropdown.value;
        }
    }

}
