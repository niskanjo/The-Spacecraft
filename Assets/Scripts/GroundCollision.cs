using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundCollision : MonoBehaviour
{
    GameObject Ground;
    // Start is called before the first frame update
    void Start()
    {
        Ground = GameObject.FindGameObjectWithTag("ground");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" && collision.relativeVelocity.magnitude > 6)
        {
            Debug.Log("Ground collision: Exceed safe velocity");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.gameObject.tag == "ground") {
            Debug.Log("Ground collision");
        }
    }
}
