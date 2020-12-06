using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayInventory : MonoBehaviour
{
    public List<InventorySlot> slots = new List<InventorySlot>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //populate slots
    public void UpdateDisplay(Player player)
    {
        int index = 0;
        //loop through players inventory and add item to slot
        foreach (var item in player.inventory.inventory.Values)
        {
            //set image and icon
           // slots[index].Item = item;
           // slots[index].icon = item.Icon;
            slots[index].SetIcon(item);
            index++;
        }
    }
}
