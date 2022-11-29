using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarCollector : MonoBehaviour
{
    GameObject[] Star;
    int collectCount;

    // Start is called before the first frame update
    void Start()
    {
        Star = GameObject.FindGameObjectsWithTag("star");
        collectCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (collectCount == Star.Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "star")
        {
            collision.gameObject.SetActive(false);
            Debug.Log("star active");
            collectCount++;
        }
    }
}
