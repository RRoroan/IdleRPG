using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>(); // 아이템 리스트

    public void AddItem(Item newItem)
    {
        items.Add(newItem);
        Debug.Log(newItem.itemName + " 추가됨");
    }

    public void RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log(item.itemName + " 제거됨");
        }
    }

    public void UseItem(Item item)
    {
        if (items.Contains(item))
        {
            item.Use();
            if (item.itemType == ItemType.Consumable)
            {
                RemoveItem(item); // 소모품은 사용 후 제거
            }
        }
    }
}