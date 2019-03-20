﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointA : MonoBehaviour {

    int ptsA = 100000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 90 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Player>().points = other.GetComponent<Player>().points + ptsA;
            //add 1 points
            Destroy(gameObject);
        }
    }
}
