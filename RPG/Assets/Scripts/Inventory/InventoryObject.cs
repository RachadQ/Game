using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour
{
    public Dictionary<uint, ItemObject> inventory = new Dictionary<uint, ItemObject>();
    DisplayInventory display;
   
    //add item to inventory
    public void AddItem(ItemObject _item, uint _amount)
    {
        

        //check if we have key and item is stackable
        if (inventory.ContainsKey(_item.StaticId) && _item.IsStackable)
        {
         
            inventory[_item.Id].AddAmount(_amount);


        }
        else
            inventory.Add(_item.Id,_item);
        

    }



    public void PrintLength()
    {
        Debug.Log(inventory.Count);
    }


}
