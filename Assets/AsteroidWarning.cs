using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidWarning : MonoBehaviour
{
    GameObject spacecraft;
    private Text warningMsg;
    // Start is called before the first frame update
    void Start()
    {
        spacecraft = GameObject.FindGameObjectWithTag("spacecraft");
        warningMsg.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, spacecraft.transform.position) < 0.5)
        {
            warningMsg.enabled = true;
        }
        else
        {
            warningMsg.enabled = false;
        }
    }
}
