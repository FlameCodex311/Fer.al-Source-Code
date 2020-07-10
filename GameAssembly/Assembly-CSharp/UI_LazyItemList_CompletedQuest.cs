/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_CompletedQuest : UI_LazyItemList<QuestItemComponent> // TypeDefIndex: 12101
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_CompletedQuest _detailPanelPrefab; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_CompletedQuest _itemPrefab; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<QuestItemComponent> _quests; // 0xF8

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12102
	{
		// Fields
		public QuestItemComponent inQuestToSelect; // 0x10

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__0(UI_LazyItemList<QuestItemComponent> item); // 0x0000000180E3E940-0x0000000180E3E970
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12103
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<QuestItemComponent>> <>9__9_0; // 0x08
		public static Comparison<UI_LazyItemList<QuestItemComponent>> <>9__9_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E3ECE0-0x0000000180E3ED40
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <SortData>b__9_0(UI_LazyItemList<QuestItemComponent> a, UI_LazyItemList<QuestItemComponent> b); // 0x0000000180E3DEE0-0x0000000180E3DFC0
		internal int <SortData>b__9_1(UI_LazyItemList<QuestItemComponent> a, UI_LazyItemList<QuestItemComponent> b); // 0x0000000180E3DFC0-0x0000000180E3E040
	}

	// Constructors
	public UI_LazyItemList_CompletedQuest(); // 0x0000000180E4A280-0x0000000180E4A2F0

	// Methods
	public void Setup(List<QuestItemComponent> inCompletedQuests, QuestItemComponent inQuestToSelect = null); // 0x0000000180E49EE0-0x0000000180E4A050
	protected override void Setup(); // 0x0000000180E4A050-0x0000000180E4A090
	protected override UI_LazyListItemDetailPanel<QuestItemComponent> GetDetailPanelReference(); // 0x000000018037A250-0x000000018037A260
	protected override UI_LazyListItem<QuestItemComponent> GetListItemPrefab(); // 0x00000001803BD320-0x00000001803BD330
	protected override List<QuestItemComponent> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override bool ItemMatchesCategory(LazyListItem<QuestItemComponent> inItem); // 0x00000001803C29F0-0x00000001803C2A00
	protected override void SortData(); // 0x0000000180E4A090-0x0000000180E4A280
	protected override string GetDataItemName(QuestItemComponent inData); // 0x0000000180E49EB0-0x0000000180E49EE0
	protected override int GetDataItemRarity(QuestItemComponent inData); // 0x000000018035FCC0-0x000000018035FCD0
	protected override bool GetDataItemFav(QuestItemComponent inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override long GetDataItemAge(QuestItemComponent inData); // 0x000000018035FCC0-0x000000018035FCD0
}

