    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : ItemObject
{
    public ItemObject item;
    
    // Start is called before the first frame update
    void Start()
    {
        item = new ConsumableObject(10,"pot","healingPeople", Resources.Load<Sprite>("pic"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
