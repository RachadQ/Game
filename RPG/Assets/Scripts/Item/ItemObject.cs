using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class ItemObject
{
    public uint StaticId { get; set; }
    public uint Id { get; set; }
    private GameObject prefab;
   public string Name { get; set; }
    public string Description { get; set; }
    public ItemType Type { get; set; }
    public Sprite Icon { get; set; }
    public bool IsStackable { get; set; }
    public uint Amount { get; set; }

    public void Setprefab(GameObject _obj)
    {
        prefab = _obj;
    }

    public GameObject GetPrefab()
    {
        return prefab;
    }


    public void AddAmount(uint val)
    {
        Amount += val;
    }

    public void RemoveAmount()
    {
        Amount = 0;
    }


}
