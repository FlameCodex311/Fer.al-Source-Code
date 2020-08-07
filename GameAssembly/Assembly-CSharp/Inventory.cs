/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class Inventory // TypeDefIndex: 11980
{
	// Fields
	private Dictionary<string, Item> _itemsById; // 0x10
	private Dictionary<ItemType, HashSet<Item>> _itemsByType; // 0x18
	private Dictionary<Type, HashSet<ItemComponent>> _itemsByComponent; // 0x20
	private Dictionary<string, HashSet<Item>> _itemsByDefId; // 0x28
	private Dictionary<ItemType, int> _itemCountByType; // 0x30
	private Dictionary<ItemType, int> _maxItemsByType; // 0x38

	// Properties
	public ICollection<Item> All { get; } // 0x000000018062E5B0-0x000000018062E600 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 11981
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <AddClientOnlyItem>b__0(IItemDefComponent c); // 0x0000000180630EB0-0x0000000180630F70
	}

	// Constructors
	public Inventory(); // 0x000000018062E130-0x000000018062E240
	public Inventory(JsonData jsonData); // 0x000000018062E240-0x000000018062E5B0

	// Methods
	public JsonData ToJson(); // 0x000000018062DC90-0x000000018062E050
	public void ParseItemMaxes(JsonData jsonData); // 0x000000018062D4A0-0x000000018062D6B0
	public void SetItemMax(ItemType itemType, int max); // 0x000000018062DC20-0x000000018062DC90
	private int DecrementItemCount(ItemType type, int amount = 1 /* Metadata: 0x007B93D6 */); // 0x000000018062C850-0x000000018062C860
	private int IncrementItemCount(ItemType type, int amount = 1 /* Metadata: 0x007B93DA */); // 0x000000018062D400-0x000000018062D4A0
	public Item AddFromServer(Item item); // 0x000000018062C130-0x000000018062C320
	public Item AddClientOnlyItem(ItemType category, BaseDef def = null); // 0x000000018062C030-0x000000018062C130
	private HashSet<Item> GetItemsByTypeSet(ItemType type); // 0x000000018062D2D0-0x000000018062D390
	private HashSet<ItemComponent> GetItemsByComponentSet(Type type); // 0x000000018062D140-0x000000018062D200
	private HashSet<Item> GetItemsByDefIdSet(string defId); // 0x000000018062D200-0x000000018062D2C0
	public Item Remove(string id); // 0x000000018062D840-0x000000018062DA10
	public void CompleteQuest(QuestItemComponent inQuest, QuestSummary inSummary); // 0x000000018062C420-0x000000018062C520
	public void CompleteQuest(string inQuestDefId, QuestSummary inSummary); // 0x000000018062C520-0x000000018062C740
	public void ReopenQuest(string inQuestDefId); // 0x000000018062DA30-0x000000018062DC20
	public void ReopenQuest(QuestItemComponent inQuest); // 0x000000018062DA10-0x000000018062DA30
	public void AddTestQuest(string inQuestId); // 0x000000018062C320-0x000000018062C420
	public void CompleteTestQuest(); // 0x000000018062C740-0x000000018062C7F0
	public void AddAllSanctuaryItemsToInventory(); // 0x000000018062BE10-0x000000018062C030
	public int GetItemCount(ItemType type); // 0x000000018062D0D0-0x000000018062D140
	public int GetItemCount(string inDefId); // 0x000000018062CEB0-0x000000018062D0D0
	public int GetMaxItems(ItemType type); // 0x000000018062D390-0x000000018062D400
	public bool Contains(string id); // 0x000000018062C7F0-0x000000018062C850
	public Item GetById(string id); // 0x000000018062CC60-0x000000018062CCD0
	public ICollection<ItemComponent> GetAllWithComponent<T>()
		where T : ItemComponent;
	public ICollection<Item> GetAllWithComponents(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ Type[] components); // 0x000000018062C870-0x000000018062CC60
	public IEnumerable<T> GetAllWithComponentAs<T>()
		where T : ItemComponent;
	public ICollection<Item> GetAllOfType(ItemType type); // 0x000000018062C860-0x000000018062C870
	public Item GetItemByDefId(string defId); // 0x000000018062CCD0-0x000000018062CE20
	public Item GetItemById(string id); // 0x000000018062CE20-0x000000018062CEB0
	public ICollection<Item> GetItemsByDefId(string defId); // 0x000000018062D2C0-0x000000018062D2D0
	[DebugButton] // 0x00000001801FEA10-0x00000001801FEA70
	public static void PrintAllLookItems(); // 0x000000018062D6B0-0x000000018062D840
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <AddFromServer>b__15_0(ItemComponent c); // 0x000000018062E050-0x000000018062E0C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Remove>b__20_0(ItemComponent c); // 0x000000018062E0C0-0x000000018062E130
}

