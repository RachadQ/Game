using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot :MonoBehaviour
{
    public ItemObject Item { get; set; }
    private Image icon;
    Sprite image;

    void Start()
    {
        icon = this.GetComponent<Image>();

    }

    public void SetIcon(ItemObject item)
    {

        Item = item;
        icon.sprite = item.Icon;
       
     
        

    }

   

}
