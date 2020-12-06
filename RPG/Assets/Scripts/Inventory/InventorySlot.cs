using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot :MonoBehaviour
{
    public ItemObject Item { get; set; }
    public Sprite icon;


    void Start()
    {
       // icon = Resources.Load<Sprite>("pic.jpg");

    }

    public void SetIcon(ItemObject item)
    {
        icon = Resources.Load<Sprite>("pic");
       

        Debug.Log("reaching");
        Image img = GetComponent<Image>();
        this.GetComponent<Image>().sprite = icon;
        img.sprite = icon;
        

    }

   

}
