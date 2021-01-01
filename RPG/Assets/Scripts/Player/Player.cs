using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
  
    private void Awake()
    {
        inventory = gameObject.AddComponent<InventoryObject>() ;
    }
    // Start is called before the first frame update
    void Start()
    {
        

       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        var _item = other.GetComponent<ItemObject>();
        //if the object has a item script
        if (_item != null)
        {
            //add item
            inventory.AddItem(_item, _item.Amount);          
            Destroy(other.gameObject);
        }
  


    }

  

}
