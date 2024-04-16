using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

// I need a movement variable and a speed variable
    public bool cars;
    public float carsspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cars == true){
            transform.position = new Vector2(transform.position.x + carsspeed, transform.position.y);    
        }
        else{
            transform.position = new Vector2(transform.position.x + carsspeed, transform.position.y);
        }
    }

    void OnCollisionEnter2D (Collision2D wall)
    {
    if(wall.collider.CompareTag("Sidewalk")){
        
        if(cars == true)
        {
            Debug.Log("hit");
            cars = false;
            carsspeed *= -1;
        }

        else if(cars == false)
        {
            cars = true;
            carsspeed *= -1;
        }
    }
    }
}
