namespace UnityLearns.LINQ.Lookup.背包;

// using UnityEngine;
using System.Collections.Generic;
using System.Linq;

// 物品类型枚举
public enum ItemType
{
    Weapon,     // 武器
    Armor,      // 防具
    Consumable, // 消耗品
    Quest       // 任务道具
}

// 简单的物品数据类 (通常是 ScriptableObject 或纯数据类)
[System.Serializable]
public class InventoryItem
{
    public string id;
    public string itemName;
    public ItemType type;
    public int amount;
    // public Sprite icon; // 实际项目中会有图标
}