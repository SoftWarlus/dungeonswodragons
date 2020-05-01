using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public string target;
    
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
        if (other.gameObject.name == "wall" || other.gameObject.tag == "obstacle")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == target)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
