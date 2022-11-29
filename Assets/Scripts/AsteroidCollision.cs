using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidCollision : MonoBehaviour
{
    GameObject[] asteroid;
    // Start is called before the first frame update
    void Start()
    {
        asteroid = GameObject.FindGameObjectsWithTag("asteroid");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Restart on asteroid collision
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
