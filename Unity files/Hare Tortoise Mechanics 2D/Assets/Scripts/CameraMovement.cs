using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // How close the mouse to the edge to move the camera
    public float offset;
    
    public float speed;

    // How far the camera can move
    public Vector2 minMaxXPosition;
    public Vector2 minMaxYPosition;

    private float screenWidth;
    private float screenHeight;
    private Vector3 cameraMove;

    // Use this for initialization
    void Start()
    {

        // Sets screen size
        screenWidth = Screen.width;
        screenHeight = Screen.height;

        cameraMove.x = transform.position.x;
        cameraMove.y = transform.position.y;
        cameraMove.z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the camera based on mouse position
        if ((Input.mousePosition.x > screenWidth - offset) && transform.position.x < minMaxXPosition.y)
        {
            cameraMove.x += MoveSpeed();
        }
        if ((Input.mousePosition.x < offset) && transform.position.x > minMaxXPosition.x)
        {
            cameraMove.x -= MoveSpeed();
        }
        if ((Input.mousePosition.y > screenHeight - offset) && transform.position.y < minMaxYPosition.y)
        {
            cameraMove.y += MoveSpeed();
        }
        if ((Input.mousePosition.y < offset) && transform.position.y > minMaxYPosition.x)
        {
            cameraMove.y -= MoveSpeed();
        }
        transform.position = cameraMove;
    }

    // How fast the camera will move
    float MoveSpeed()
    {
        return speed * Time.deltaTime;
    }
}