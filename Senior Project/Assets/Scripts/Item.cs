using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item
{
    private int id, max, value;
    private string name, desc;
    private bool equip, key;

    public Item(int id, int max, int value, string name, string desc, bool equip, bool key)
    {
        this.id = id;
        this.max = max;
        this.value = value;
        this.name = name;
        this.desc = desc;
        this.equip = equip;
        this.key = key;
    }


    // Get Functions
    public int ID { get { return id; } }
    public int Max { get { return max; } }
    public int Value { get { return value; } }
    public string Name { get { return name; } }
    public string Desc { get { return desc; } }
    public bool Equip { get { return equip; } }
    public bool Key { get { return key; } }
    public override string ToString()
    {
        return id + " " + max + " " + value + " " + name + " " + desc + " " + equip + " " + key;
    }
}
