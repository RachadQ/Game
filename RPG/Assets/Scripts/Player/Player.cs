using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory = new InventoryObject();
    public DisplayInventory inv;

    private void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Finish").GetComponent<InventoryObject>();

        inv = GameObject.FindGameObjectWithTag("Finish").GetComponent<DisplayInventory>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Rea  cc");
        var _item = other.GetComponent<Item>();
        var _item2 = other.GetComponent<Tempt>();
        //if the object has a item script
        if (_item )
        {
            //add item
            inventory.AddItem(_item.item, 1);
            Debug.Log(inventory.inventory[_item.item.Id].Name);
            inventory.PrintLength();
            inv.UpdateDisplay(this);
            Destroy(other.gameObject);
        }
        else if (_item2)
        {
            //add item
            inventory.AddItem(_item2.item, 1);
            Debug.Log(inventory.inventory[_item2.item.Id].Name);
            inventory.PrintLength();
            inv.UpdateDisplay(this);
            Destroy(other.gameObject);
        }


    }

  

}
