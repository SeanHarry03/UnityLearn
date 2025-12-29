namespace UnityLearns.LINQ.Lookup.背包;

// using UnityEngine;
// using UnityEngine.UI;
//
// public class InventoryUI : MonoBehaviour
// {
//     public InventoryManager inventoryManager;
//     public Transform contentPanel; // ScrollView 的 Content
//     public GameObject itemSlotPrefab; // 物品格子的预制体
//
//     // 绑定到 UI 按钮的点击事件：点击 "显示武器" 按钮
//     public void OnClickFilterWeapon()
//     {
//         UpdateDisplay(ItemType.Weapon);
//     }
//
//     // 绑定到 UI 按钮的点击事件：点击 "显示消耗品" 按钮
//     public void OnClickFilterConsumable()
//     {
//         UpdateDisplay(ItemType.Consumable);
//     }
//
//     // 通用的刷新显示逻辑
//     private void UpdateDisplay(ItemType type)
//     {
//         // 1. 清理旧 UI (简单粗暴法)
//         foreach (Transform child in contentPanel) Destroy(child.gameObject);
//
//         // 2. 从 Lookup 中极速获取数据
//         var itemsToShow = inventoryManager.GetItemsByType(type);
//
//         // 3. 生成新 UI
//         foreach (var item in itemsToShow)
//         {
//             var slot = Instantiate(itemSlotPrefab, contentPanel);
//             // slot.GetComponent<ItemSlotUI>().Setup(item); // 设置图标和文字...
//             Debug.Log($"UI 生成了: {item.itemName}");
//         }
//         
//         // Lookup 的安全性体现：
//         // 如果 itemsToShow 为空（比如没有该类物品），循环直接跳过，不会报错，非常适合 UI 逻辑
//     }
// }