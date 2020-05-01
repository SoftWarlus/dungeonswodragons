using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


public class InventoryManager : MonoBehaviour
{
    public ArrayList inventory = new ArrayList();
    public TextAsset itemList;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(int itemID)
    {
        string[] item = findItem(itemID);
        if (item != null)
        {
            inventory.Add(new Item(Int32.Parse(item[0]), Int32.Parse(item[1]), Int32.Parse(item[2]), item[3], item[4], bool.Parse(item[5]), bool.Parse(item[6])));
            Debug.Log(inventory[0].ToString());
        } 
        else
        {
            Debug.Log("INVALID ITEM ID");
        }
    }

    string[] findItem(int itemID)
    {
        string text = itemList.text;
        string[] lines = Regex.Split(text, "\n|\r|\r\n");
        string[] values = new string[lines.Length];

        foreach (string s in lines)
        {
            values = Regex.Split(s, ", ");
            if (Int32.Parse(values[0]) == itemID)
            {
                return values;
            }
        }

        return null;
    }


}
