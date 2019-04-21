﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletCollector : MonoBehaviour
{

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pellet")
        {

            count++;
            Debug.Log("Collected Pellets: " + count);

            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
        }
    }
}
