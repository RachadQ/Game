using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipableObjects : ItemObject
{

    // Start is called before the first frame update
    void Start()
    {
        Icon = Resources.Load<Sprite>("pic");
        IsStackable = true;
        StaticId = 1;
        Amount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
