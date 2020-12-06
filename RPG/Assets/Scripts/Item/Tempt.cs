using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tempt : MonoBehaviour
{
    public ItemObject item;

    // Start is called before the first frame update
    void Start()
    {
        item = new ConsumableObject(11, "pot", "healingPeople", Resources.Load<Sprite>("pic.jpg"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
