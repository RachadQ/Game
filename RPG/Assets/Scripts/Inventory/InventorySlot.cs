using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//keep track of slot
public class InventorySlot :MonoBehaviour
{
    public ItemObject Item { get; set; }
    private Image icon;
    public uint amount { get; set; }

    void Start()
    {
        icon = this.GetComponent<Image>();

    }

    //set item and icon
    public void SetIcon(ItemObject item)
    {

        UpdateSlot(item.StaticId, item, item.Amount);
        icon.sprite = item.Icon;
       
    }

    public void UpdateSlot(uint _id,ItemObject _item, uint _amount)
    {
        Item = _item;
        amount = _amount;

    }

    //clear ui and item
    public void ClearSlot()
    {

        Item = null;
        icon.sprite = null;
    }

   

}
