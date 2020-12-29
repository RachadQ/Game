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
        
        var _item = other.GetComponent<Item>();
        //if the object has a item script
        if (_item != null)
        {
            //add item
            inventory.AddItem(_item.item, 1);          
            Destroy(other.gameObject);
        }
  


    }

  

}
