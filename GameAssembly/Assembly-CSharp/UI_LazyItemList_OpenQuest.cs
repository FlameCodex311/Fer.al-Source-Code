/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_OpenQuest : UI_LazyItemList<QuestItemComponent> // TypeDefIndex: 13650
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_OpenQuest _detailPanelPrefab; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_OpenQuest _itemPrefab; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<QuestItemComponent> _quests; // 0xF8

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 13651
	{
		// Fields
		public UI_LazyItemList_OpenQuest <>4__this; // 0x10
		public QuestItemComponent inQuestToSelect; // 0x18
		public Predicate<UI_LazyItemList<QuestItemComponent>> <>9__1; // 0x20

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__0(); // 0x0000000180387E90-0x0000000180387F60
		internal bool <Setup>b__1(UI_LazyItemList<QuestItemComponent> item); // 0x0000000180387F60-0x0000000180387F80
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13652
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<QuestItemComponent>> <>9__9_0; // 0x08
		public static Comparison<UI_LazyItemList<QuestItemComponent>> <>9__9_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180388000-0x0000000180388060
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <SortData>b__9_0(UI_LazyItemList<QuestItemComponent> a, UI_LazyItemList<QuestItemComponent> b); // 0x0000000180387980-0x0000000180387A50
		internal int <SortData>b__9_1(UI_LazyItemList<QuestItemComponent> a, UI_LazyItemList<QuestItemComponent> b); // 0x0000000180373180-0x0000000180373200
	}

	// Constructors
	public UI_LazyItemList_OpenQuest(); // 0x000000018038BC50-0x000000018038BCC0

	// Methods
	public void Setup(List<QuestItemComponent> inOpenQuests, QuestItemComponent inQuestToSelect = null); // 0x000000018038B8F0-0x000000018038BA20
	protected override void Setup(); // 0x000000018038BA20-0x000000018038BA60
	protected override UI_LazyListItemDetailPanel<QuestItemComponent> GetDetailPanelReference(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override UI_LazyListItem<QuestItemComponent> GetListItemPrefab(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override List<QuestItemComponent> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override bool ItemMatchesCategory(LazyListItem<QuestItemComponent> inItem); // 0x0000000180380B60-0x0000000180380B70
	protected override void SortData(); // 0x000000018038BA60-0x000000018038BC50
	protected override string GetDataItemName(QuestItemComponent inData); // 0x0000000180382370-0x0000000180382390
	protected override int GetDataItemRarity(QuestItemComponent inData); // 0x000000018037DDC0-0x000000018037DDD0
	protected override bool GetDataItemFav(QuestItemComponent inData); // 0x0000000180380950-0x0000000180380960
	protected override long GetDataItemAge(QuestItemComponent inData); // 0x000000018037DDC0-0x000000018037DDD0
}

