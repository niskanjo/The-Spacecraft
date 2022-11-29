using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidWarning : MonoBehaviour
{
    GameObject[] asteroid;
    [SerializeField]
    public Text warningMsg;
    // Start is called before the first frame update
    void Start()
    {
        asteroid = GameObject.FindGameObjectsWithTag("asteroid");
        warningMsg.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (
                Vector2.Distance(transform.position, asteroid[0].transform.position) < 4 ||
                Vector2.Distance(transform.position, asteroid[1].transform.position) < 4 ||
                Vector2.Distance(transform.position, asteroid[2].transform.position) < 4
           )
        {
            warningMsg.enabled = true;
            Debug.Log("asteroid warning " + warningMsg.enabled);
        }
        else
        {
            warningMsg.enabled = false;
            Debug.Log("asteroid warning " + warningMsg.enabled);
        }
    }
}
