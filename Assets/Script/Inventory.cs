using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>(); // ������ ����Ʈ

    public void AddItem(Item newItem)
    {
        items.Add(newItem);
        Debug.Log(newItem.itemName + " �߰���");
    }

    public void RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log(item.itemName + " ���ŵ�");
        }
    }

    public void UseItem(Item item)
    {
        if (items.Contains(item))
        {
            item.Use();
            if (item.itemType == ItemType.Consumable)
            {
                RemoveItem(item); // �Ҹ�ǰ�� ��� �� ����
            }
        }
    }
}