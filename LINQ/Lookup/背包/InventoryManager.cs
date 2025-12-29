namespace UnityLearns.LINQ.Lookup.背包;

 
// public class InventoryManager : MonoBehaviour
// {
//     // 原始的扁平化物品列表 (可能从 SaveData 加载)
//     [SerializeField] private List<InventoryItem> allItems = new List<InventoryItem>();
//
//     // 【核心】缓存的查找表：Key是物品类型，Value是该类型下的所有物品
//     private ILookup<ItemType, InventoryItem> _itemLookup;
//
//     void Start()
//     {
//         // 模拟初始化一些数据
//         LoadMockData();
//
//
//         // 建立缓存
//         RebuildInventoryCache();
//
//         // 测试：获取所有消耗品
//         Debug.Log("--- 初始化完成，打印消耗品 ---");
//         var potions = GetItemsByType(ItemType.Consumable);
//         foreach (var p in potions) Debug.Log($"找到了: {p.itemName}");
//     }
//
//     /// <summary>
//     /// 当背包数据发生变化（增删改）时，调用此方法重建索引
//     /// </summary>
//     public void RebuildInventoryCache()
//     {
//         // ToLookup 会立即遍历 allItems 并按 type 分组
//         // 即使 allItems 很大，这个操作通常也很快，但在大量数据下不要在 Update 中调用
//         _itemLookup = allItems.ToLookup(item => item.type);
//
//         Debug.Log($"索引重建完成。背包中共有 {allItems.Count} 个物品，被分为了 {_itemLookup.Count} 类。");
//     }
//
//     /// <summary>
//     /// UI 调用的接口：根据类型获取物品列表
//     /// </summary>
//     public IEnumerable<InventoryItem> GetItemsByType(ItemType type)
//     {
//         // 保护机制：如果还没初始化，先尝试建立缓存
//         if (_itemLookup == null) RebuildInventoryCache();
//
//         // 【优势】这里是 O(1) 复杂度的查找（类似于字典）
//         // 如果该类型下没有任何物品（例如没有任务道具），
//         // 它会直接返回一个空的 IEnumerable，而不会报 KeyNotFound 错，也不用判空！
//         return _itemLookup[type];
//     }
//
//     // --- 模拟数据 ---
//     private void LoadMockData()
//     {
//         allItems = new List<InventoryItem>
//         {
//             new InventoryItem { itemName = "屠龙刀", type = ItemType.Weapon, amount = 1 },
//             new InventoryItem { itemName = "布甲", type = ItemType.Armor, amount = 1 },
//             new InventoryItem { itemName = "小红药", type = ItemType.Consumable, amount = 10 },
//             new InventoryItem { itemName = "倚天剑", type = ItemType.Weapon, amount = 1 },
//             new InventoryItem { itemName = "魔法水", type = ItemType.Consumable, amount = 5 }
//         };
//     }
// }