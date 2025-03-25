using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;  // 아이템 이름
    public Sprite icon;  // 아이템 이미지
    public ItemType itemType;  // 아이템 타입
    public int value;  // 아이템 효과 값 (예: 체력 회복량, 공격력 증가 등)

    public virtual void Use()
    {
        Debug.Log(itemName + " 사용!");
    }
}

public enum ItemType
{
    Consumable,  // 소모품 (예: 체력 포션)
    Equipment,   // 장비 아이템 (예: 검, 방어구)
    Currency     // 화폐 (예: 골드)
}