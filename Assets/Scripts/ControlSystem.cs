using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    public Vector2 Force;
    Rigidbody2D Physics;

    // Start is called before the first frame update
    void Start()
    {
        Physics = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        Physics.AddForce(Force);
        // Accelerate spacecraft
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            Force.y = 0.6f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            Force.y = -0.6f;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            Force.x = -0.6f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            Force.x = 0.6f;
        }
        // Stop spacecraft thrust
        if (Input.GetKeyUp(KeyCode.UpArrow) == true)
        {
            Force.y = 0f;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) == true)
        {
            Force.y = 0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) == true)
        {
            Force.x = 0f;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) == true)
        {
            Force.x = 0f;
        }
    }
}
