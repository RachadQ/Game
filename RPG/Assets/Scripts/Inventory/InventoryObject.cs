using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handle inventory backend
public class InventoryObject : MonoBehaviour
{
    public Dictionary<uint, ItemObject> inventory = new Dictionary<uint, ItemObject>();
    public DisplayInventory inventoryUi;
   
    //add item to inventory
    public void AddItem(ItemObject _item, uint _amount)
    {


        //check if we have key and item is stackable
        if (inventory.ContainsKey(_item.StaticId) && _item.IsStackable == true) 
        {
         
            inventory[_item.StaticId].AddAmount(_amount);


        }
        else
            inventory.Add(_item.StaticId,_item);

        inventoryUi.UpdateDisplay(this);
    }

    //Remove item
    public void RemoveItem(ItemObject _item, uint _amount)
    {
        _item = null;
        _amount = 0;

        if (inventory.ContainsKey(_item.StaticId) && _item.IsStackable == true)
        {

            inventory[_item.StaticId].AddAmount(_amount);


        }
        else
            inventory.Add(_item.StaticId, _item);

        inventoryUi.UpdateDisplay(this);
    }



    //get slot
    public InventorySlot SetEmptySlot(int index)
    {
        //loop through the slot
        for (int i = 0; i < inventory.Count; i++)
        {
            if (i == index)
            {
                //and clear it
                inventoryUi.slots[index].ClearSlot();
            }
        }
        return null;

    }


   


}
