using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public ResourceManager playerInventory;
    public bool needsKey;
    public Sprite Open;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "knight" && needsKey)
        {
            if (playerInventory.sKeys >= 1)
            {
                this.gameObject.SetActive(false);
                playerInventory.sKeys--;
            }
            //this.GetComponent<SpriteRenderer>().sprite = Open;
        } 
        else
        {
            this.gameObject.SetActive(false);
        }
        
    }
}
