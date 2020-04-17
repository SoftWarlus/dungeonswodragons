﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour
{
    public int damage;
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
        if (other.gameObject.name == "knight")
        {
            other.gameObject.GetComponent<ResourceManager>().DamagePlayer(damage);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "knight")
        {
            other.gameObject.GetComponent<ResourceManager>().DamagePlayer(damage);
        }
    }
}
