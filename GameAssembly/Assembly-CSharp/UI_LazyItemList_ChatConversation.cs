/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_ChatConversation : UI_LazyItemList<ChatConversationData> // TypeDefIndex: 13501
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ChatConversation _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_ChatConversation _detailPanelReference; // 0xF0
	private List<ChatConversationData> _dataItems; // 0xF8

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13502
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<ChatConversationData>> <>9__11_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180373C50-0x0000000180373CB0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <SortData>b__11_0(UI_LazyItemList<ChatConversationData> a, UI_LazyItemList<ChatConversationData> b); // 0x0000000180372F20-0x0000000180373020
	}

	// Constructors
	public UI_LazyItemList_ChatConversation(); // 0x000000018037FEF0-0x000000018037FF30

	// Methods
	protected override void Start(); // 0x000000018037FE10-0x000000018037FEF0
	private void OnDestroy(); // 0x000000018037F940-0x000000018037FA10
	public void RecalculateLayout(); // 0x000000018037FA10-0x000000018037FC70
	public void ManualSetup(); // 0x000000018037F800-0x000000018037F820
	protected override void Setup(); // 0x000000018037FC70-0x000000018037FD10
	protected override List<ChatConversationData> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<ChatConversationData> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<ChatConversationData> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x000000018037FD10-0x000000018037FE10
	private void OnConversationAdded(CachedConversationAddedMessage inMessage); // 0x000000018037F820-0x000000018037F8B0
	private void OnConversationRemoved(CachedConversationRemovedMessage inMessage); // 0x000000018037F8B0-0x000000018037F940
}

