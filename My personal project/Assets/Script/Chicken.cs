using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{

    //direction variables
    private Vector2 direction;
    bool goingUp;
    bool goingDown;
    bool goingLeft;
    bool goingRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;



            goingUp = true;
            goingLeft = false;
            goingDown = false;
            goingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;


            goingUp = false;
            goingLeft = true;
            goingDown = false;
            goingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector2.down;


            goingUp = false;
            goingLeft = false;
            goingDown = true;
            goingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;


            goingUp = false;
            goingLeft = false;
            goingDown = false;
            goingRight = true;
        }
        else { direction = Vector2.zero; }
        transform.position = new Vector2
           ((transform.position.x) + direction.x,
           (transform.position.y) + direction.y);


    }
}
