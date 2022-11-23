using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AsteroidCollision : MonoBehaviour
{
    GameObject[] asteroid;
    //private Text warningMsg;
    // Start is called before the first frame update
    void Start()
    {
        asteroid = GameObject.FindGameObjectsWithTag("asteroid");
        //warningMsg.enabled = false;
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
    
    // 
    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            warningMsg.enabled = true;
        }
    }*/
}
