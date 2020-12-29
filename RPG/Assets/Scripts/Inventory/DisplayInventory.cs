using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//handle ui
public class DisplayInventory : MonoBehaviour
{
    public InventorySlot[] slots = new InventorySlot[30];
   

    
    //populate slots
    public void UpdateDisplay(InventoryObject inventory)
    {
        int index = 0;
        //loop through players inventory and add item to slot
        foreach (var item in inventory.inventory.Values)
        {
            slots[index].SetIcon(item);
            index++;
        }
    }



}
