using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;  // ������ �̸�
    public Sprite icon;  // ������ �̹���
    public ItemType itemType;  // ������ Ÿ��
    public int value;  // ������ ȿ�� �� (��: ü�� ȸ����, ���ݷ� ���� ��)

    public virtual void Use()
    {
        Debug.Log(itemName + " ���!");
    }
}

public enum ItemType
{
    Consumable,  // �Ҹ�ǰ (��: ü�� ����)
    Equipment,   // ��� ������ (��: ��, ��)
    Currency     // ȭ�� (��: ���)
}