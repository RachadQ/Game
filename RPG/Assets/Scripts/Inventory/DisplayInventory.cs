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
            
            
            slots[index].amount += item.Amount;
            //else set icon         
                while (slots[index].isUse == true)
                {
                    index++;
                }

                slots[index].SetIcon(item);
               
            
           
                
        }
    }

    public void UpdateAmount(uint _amount,uint key)
    {
        //loop through each slot to see if key == item ket
        foreach(var slot in slots)
        if (key == slot.Item.StaticId)
        {
                //update the slots amont
                slot.amount += _amount;
                Debug.Log(slot.amount);
                return;
        }
    }


}
