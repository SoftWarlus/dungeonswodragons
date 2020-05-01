using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public int maxHP;
    public int currentHP;
    public int maxMP;
    public int currentMP;
    public int sKeys;


    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void Reset()
    {
        currentHP = maxHP;
        currentMP = maxMP;
        sKeys = 0;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "sKey1")
        {
            other.gameObject.SetActive(false);
            sKeys++;
        }
        if (other.gameObject.name == "chest1")
        {
            other.gameObject.GetComponent<Animator>().SetBool("opened", true);
        }
    }

}
