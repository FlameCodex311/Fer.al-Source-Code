/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_NotificationLog : UI_LazyItemList<Notification> // TypeDefIndex: 13642
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_NotificationLog _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _allCaughtUpGroup; // 0xF0
	private LazyLayoutElement _allCaughtUpElement; // 0xF8
	private List<Notification> _dataItems; // 0x100
	private Waiter _refreshWaiter; // 0x108

	// Properties
	public LazyLayoutElement AllCaughtUpElement { get; } // 0x000000018037E230-0x000000018037E240 

	// Constructors
	public UI_LazyItemList_NotificationLog(); // 0x000000018038B8B0-0x000000018038B8F0

	// Methods
	protected override void Setup(); // 0x000000018038B4F0-0x000000018038B6D0
	protected override void Start(); // 0x000000018038B6F0-0x000000018038B790
	private void OnDestroy(); // 0x000000018038B0F0-0x000000018038B180
	private void OnNotificationSent(NotificationSentMessage inMessage); // 0x000000018038B180-0x000000018038B220
	protected override void PostListFilter(int inShownItemsCount); // 0x000000018038B220-0x000000018038B280
	private void RefreshAllCaughtUpGroup(int inFrameDelay = 1 /* Metadata: 0x007BA4A1 */); // 0x000000018038B280-0x000000018038B4F0
	protected override List<Notification> GetDataItems(); // 0x000000018037F030-0x000000018037F040
	protected override UI_LazyListItemDetailPanel<Notification> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<Notification> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(Notification inData); // 0x000000018038B0D0-0x000000018038B0F0
	protected override long GetDataItemAge(Notification inData); // 0x000000018038B0B0-0x000000018038B0D0
	protected override void SortData(); // 0x000000018038B6D0-0x000000018038B6F0
	protected override LazyLayoutInfo CreateLayoutInfo(Notification inItem); // 0x000000018038AFE0-0x000000018038B0B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshAllCaughtUpGroup>b__12_0(); // 0x000000018038B790-0x000000018038B8B0
}

