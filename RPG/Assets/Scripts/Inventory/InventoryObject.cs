using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inventory controller
public class InventoryObject : MonoBehaviour
{
    public Dictionary<uint, ItemObject> inventory = new Dictionary<uint, ItemObject>();
    public DisplayInventory inventoryUi;

    void Start()
    {
        inventoryUi = GameObject.FindGameObjectWithTag("Finish").GetComponent<DisplayInventory>();



    }
    //add item to inventory
    public void AddItem(ItemObject _item, uint _amount)
    {
        //make a copy of item
        ItemObject copy = _item;
        
        //check if we have key and item is stackable
        if (inventory.ContainsKey(copy.StaticId) ) 
        {
            if (copy.IsStackable == true)
            {
               
                inventory[copy.StaticId].AddAmount(_amount);
                inventoryUi.UpdateAmount(_amount,copy.StaticId);
                return;
            }
            else
                inventory.Add(copy.StaticId, copy);
            Debug.Log(inventory[copy.StaticId].Amount);



        }
        else
            inventory.Add(copy.StaticId, copy);


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
