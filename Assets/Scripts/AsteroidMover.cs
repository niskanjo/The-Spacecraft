using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{
    GameObject[] star;
    int i;
    float speed = 0.008f;

    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.FindGameObjectsWithTag("star");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, star[i].transform.position, speed);
        // Asteroids move towards a random star
        if (Vector2.Distance(transform.position, star[i].transform.position) == 0)
        {
            i = Random.Range(0, star.Length);
        }
    }
}
