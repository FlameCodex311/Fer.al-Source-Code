/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_OpenQuest : UI_LazyItemList<QuestItemComponent> // TypeDefIndex: 12104
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_OpenQuest _detailPanelPrefab; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_OpenQuest _itemPrefab; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<QuestItemComponent> _quests; // 0xF8

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12105
	{
		// Fields
		public UI_LazyItemList_OpenQuest <>4__this; // 0x10
		public QuestItemComponent inQuestToSelect; // 0x18
		public Predicate<UI_LazyItemList<QuestItemComponent>> <>9__1; // 0x20

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__0(); // 0x0000000180E3E970-0x0000000180E3EA40
		internal bool <Setup>b__1(UI_LazyItemList<QuestItemComponent> item); // 0x0000000180E3EA40-0x0000000180E3EA70
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12106
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<QuestItemComponent>> <>9__9_0; // 0x08
		public static Comparison<UI_LazyItemList<QuestItemComponent>> <>9__9_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E3EC80-0x0000000180E3ECE0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <SortData>b__9_0(UI_LazyItemList<QuestItemComponent> a, UI_LazyItemList<QuestItemComponent> b); // 0x0000000180E3DE00-0x0000000180E3DEE0
		internal int <SortData>b__9_1(UI_LazyItemList<QuestItemComponent> a, UI_LazyItemList<QuestItemComponent> b); // 0x0000000180E3DFC0-0x0000000180E3E040
	}

	// Constructors
	public UI_LazyItemList_OpenQuest(); // 0x0000000180E52DD0-0x0000000180E52E40

	// Methods
	public void Setup(List<QuestItemComponent> inOpenQuests, QuestItemComponent inQuestToSelect = null); // 0x0000000180E52A60-0x0000000180E52BA0
	protected override void Setup(); // 0x0000000180E52BA0-0x0000000180E52BE0
	protected override UI_LazyListItemDetailPanel<QuestItemComponent> GetDetailPanelReference(); // 0x000000018037A250-0x000000018037A260
	protected override UI_LazyListItem<QuestItemComponent> GetListItemPrefab(); // 0x00000001803BD320-0x00000001803BD330
	protected override List<QuestItemComponent> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override bool ItemMatchesCategory(LazyListItem<QuestItemComponent> inItem); // 0x00000001803C29F0-0x00000001803C2A00
	protected override void SortData(); // 0x0000000180E52BE0-0x0000000180E52DD0
	protected override string GetDataItemName(QuestItemComponent inData); // 0x0000000180E49EB0-0x0000000180E49EE0
	protected override int GetDataItemRarity(QuestItemComponent inData); // 0x000000018035FCC0-0x000000018035FCD0
	protected override bool GetDataItemFav(QuestItemComponent inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override long GetDataItemAge(QuestItemComponent inData); // 0x000000018035FCC0-0x000000018035FCD0
}

