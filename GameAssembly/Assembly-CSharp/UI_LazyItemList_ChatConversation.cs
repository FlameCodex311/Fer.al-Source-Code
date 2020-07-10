/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_ChatConversation : UI_LazyItemList<ChatConversationData> // TypeDefIndex: 11955
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_ChatConversation _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_ChatConversation _detailPanelReference; // 0xF0
	private List<ChatConversationData> _dataItems; // 0xF8

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11956
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<ChatConversationData>> <>9__11_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E3EC20-0x0000000180E3EC80
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <SortData>b__11_0(UI_LazyItemList<ChatConversationData> a, UI_LazyItemList<ChatConversationData> b); // 0x0000000180E3DD00-0x0000000180E3DE00
	}

	// Constructors
	public UI_LazyItemList_ChatConversation(); // 0x0000000180E48020-0x0000000180E48060

	// Methods
	protected override void Start(); // 0x0000000180E47F40-0x0000000180E48020
	private void OnDestroy(); // 0x0000000180E47A60-0x0000000180E47B30
	public void RecalculateLayout(); // 0x0000000180E47B30-0x0000000180E47DA0
	public void ManualSetup(); // 0x00000001806A3950-0x00000001806A3970
	protected override void Setup(); // 0x0000000180E47DA0-0x0000000180E47E40
	protected override List<ChatConversationData> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<ChatConversationData> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<ChatConversationData> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x0000000180E47E40-0x0000000180E47F40
	private void OnConversationAdded(CachedConversationAddedMessage inMessage); // 0x0000000180E47940-0x0000000180E479D0
	private void OnConversationRemoved(CachedConversationRemovedMessage inMessage); // 0x0000000180E479D0-0x0000000180E47A60
}

