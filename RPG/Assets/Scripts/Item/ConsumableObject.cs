using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConsumableObject : ItemObject
{
    public uint Health { get; set; }
    public uint Mana { get; set; }
    void Awake()
    {
        Type = ItemType.Consumable;
    }
   
    public ConsumableObject(uint _id,string _name,string _decription,Sprite _icon ,bool isStackable = true ) 
    {
        Id = _id;
        Name = _name;
        Description = _decription;
        Icon = _icon;
        IsStackable = isStackable;
    }
}
