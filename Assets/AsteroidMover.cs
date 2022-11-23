using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{
    GameObject[] star;
    int index;
    float speed = 0.008f;

    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.FindGameObjectsWithTag("star");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, star[index].transform.position, speed);

        if (Vector2.Distance(transform.position, star[index].transform.position) < 0.5)
        {
            index = Random.Range(0, star.Length);
        }
    }
}
