using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harm : MonoBehaviour
{
    public int damage;
    public string immune;
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
        if (other.gameObject.name != immune && other.gameObject.name == "knight")
        {
            other.gameObject.GetComponent<ResourceManager>().currentHP -= damage;
        }
        else if (other.gameObject.tag != immune && other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHP>().currentHP -= damage;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name != immune && other.gameObject.name == "knight")
        {
            other.gameObject.GetComponent<ResourceManager>().currentHP -= damage;
        }
        else if (other.gameObject.tag != immune && other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHP>().currentHP -= damage;
        }
    }
}
