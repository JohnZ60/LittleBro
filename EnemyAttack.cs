﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit on: " + other.gameObject.name);
        if (other.gameObject.transform.parent.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Hit on: " + other.gameObject.name);
        }
    }



}
