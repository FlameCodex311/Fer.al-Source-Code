/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class Inventory // TypeDefIndex: 10492
{
	// Fields
	private Dictionary<string, Item> _itemsById; // 0x10
	private Dictionary<ItemType, HashSet<Item>> _itemsByType; // 0x18
	private Dictionary<Type, HashSet<ItemComponent>> _itemsByComponent; // 0x20
	private Dictionary<string, HashSet<Item>> _itemsByDefId; // 0x28
	private Dictionary<ItemType, int> _itemCountByType; // 0x30
	private Dictionary<ItemType, int> _maxItemsByType; // 0x38

	// Properties
	public ICollection<Item> All { get; } // 0x0000000180F66880-0x0000000180F668D0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 10493
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <AddClientOnlyItem>b__0(IItemDefComponent c); // 0x0000000180F6FDB0-0x0000000180F6FE70
	}

	// Constructors
	public Inventory(); // 0x0000000180F66400-0x0000000180F66510
	public Inventory(JsonData jsonData); // 0x0000000180F66510-0x0000000180F66880

	// Methods
	public JsonData ToJson(); // 0x0000000180F65F20-0x0000000180F66300
	public void ParseItemMaxes(JsonData jsonData); // 0x0000000180F656F0-0x0000000180F65910
	public void SetItemMax(ItemType itemType, int max); // 0x0000000180F65EB0-0x0000000180F65F20
	private int DecrementItemCount(ItemType type, int amount = 1 /* Metadata: 0x00781D2B */); // 0x0000000180F64A70-0x0000000180F64A80
	private int IncrementItemCount(ItemType type, int amount = 1 /* Metadata: 0x00781D2F */); // 0x0000000180F65650-0x0000000180F656F0
	public Item AddFromServer(Item item); // 0x0000000180F64330-0x0000000180F64530
	public Item AddClientOnlyItem(ItemType category, BaseDef def = null); // 0x0000000180F64230-0x0000000180F64330
	private HashSet<Item> GetItemsByTypeSet(ItemType type); // 0x0000000180F65520-0x0000000180F655E0
	private HashSet<ItemComponent> GetItemsByComponentSet(Type type); // 0x0000000180F65390-0x0000000180F65450
	private HashSet<Item> GetItemsByDefIdSet(string defId); // 0x0000000180F65450-0x0000000180F65510
	public Item Remove(string id); // 0x0000000180F65AB0-0x0000000180F65C90
	public int GetItemCount(ItemType type); // 0x0000000180F65320-0x0000000180F65390
	public int GetItemCount(string inDefId); // 0x0000000180F650F0-0x0000000180F65320
	public int GetMaxItems(ItemType type); // 0x0000000180F655E0-0x0000000180F65650
	public bool Contains(string id); // 0x0000000180F64A10-0x0000000180F64A70
	public Item GetById(string id); // 0x0000000180F64EA0-0x0000000180F64F10
	public ICollection<ItemComponent> GetAllWithComponent<T>()
		where T : ItemComponent;
	public ICollection<Item> GetAllWithComponents(params /* 0x00000001800B36B0-0x00000001800B36C0 */ Type[] components); // 0x0000000180F64A90-0x0000000180F64EA0
	public IEnumerable<T> GetAllWithComponentAs<T>()
		where T : ItemComponent;
	public ICollection<Item> GetAllOfType(ItemType type); // 0x0000000180F64A80-0x0000000180F64A90
	public Item GetItemByDefId(string defId); // 0x0000000180F64F10-0x0000000180F65060
	public Item GetItemById(string id); // 0x0000000180F65060-0x0000000180F650F0
	public ICollection<Item> GetItemsByDefId(string defId); // 0x0000000180F65510-0x0000000180F65520
	[DebugButton] // 0x0000000180129560-0x00000001801295C0
	public static void PrintAllLookItems(); // 0x0000000180F65910-0x0000000180F65AB0
	public void CompleteQuest(QuestItemComponent inQuest, QuestSummary inSummary); // 0x0000000180F64640-0x0000000180F64740
	public void CompleteQuest(string inQuestDefId, QuestSummary inSummary); // 0x0000000180F64740-0x0000000180F64960
	public void ReopenQuest(string inQuestDefId); // 0x0000000180F65CC0-0x0000000180F65EB0
	public void ReopenQuest(QuestItemComponent inQuest); // 0x0000000180F65C90-0x0000000180F65CC0
	public void AddTestQuest(string inQuestId); // 0x0000000180F64530-0x0000000180F64640
	public void CompleteTestQuest(); // 0x0000000180F64960-0x0000000180F64A10
	public void AddAllSanctuaryItemsToInventory(); // 0x0000000180F64000-0x0000000180F64230
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <AddFromServer>b__15_0(ItemComponent c); // 0x0000000180F66300-0x0000000180F66380
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Remove>b__20_0(ItemComponent c); // 0x0000000180F66380-0x0000000180F66400
}

