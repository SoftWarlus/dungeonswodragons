using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
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
        else if (gameObject.GetComponent<Harm>().immune != other.gameObject.tag && gameObject.GetComponent<Harm>().immune != other.gameObject.name)
        {
            Destroy(gameObject);
        }
    }
}
