using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    Vector2 Velocity;
    // Start is called before the first frame update
    void Start()
    {
        Velocity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Velocity.x = 0;
        Velocity.y = 0;

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            Velocity.y = 0.03f;
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            Velocity.y = -0.03f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            Velocity.x = -0.03f;
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            Velocity.x = 0.03f;
        }

        transform.Translate(Velocity);
    }
}
