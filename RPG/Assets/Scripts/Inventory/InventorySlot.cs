using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//keep track of slot
public class InventorySlot :MonoBehaviour
{
    public ItemObject Item;
    private Image icon;
    public bool isUse = false;
    public uint amount { get; set; }

    void Start()
    {
        icon = this.GetComponent<Image>();

    }

   

    //set item and icon
    public void SetIcon(ItemObject item)
    {

        //Update slot and sprite
        UpdateSlot( item, item.Amount);
        icon.sprite = item.Icon;
       
    }

    public void UpdateSlot(ItemObject _item, uint _amount)
    {
        Item = _item;
        amount = _amount;
        isUse = true;
    }

    //clear ui and item
    public void ClearSlot()
    {

        Item = null;
        icon.sprite = null;
        isUse = false;
    }

   

}
