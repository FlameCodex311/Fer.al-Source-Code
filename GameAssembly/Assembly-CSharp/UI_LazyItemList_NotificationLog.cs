/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_NotificationLog : UI_LazyItemList<Notification> // TypeDefIndex: 12093
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_NotificationLog _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _allCaughtUpGroup; // 0xF0
	private LazyLayoutElement _allCaughtUpElement; // 0xF8
	private List<Notification> _dataItems; // 0x100
	private Waiter _refreshWaiter; // 0x108

	// Properties
	public LazyLayoutElement AllCaughtUpElement { get; } // 0x00000001803BD310-0x00000001803BD320 

	// Constructors
	public UI_LazyItemList_NotificationLog(); // 0x0000000180E52A20-0x0000000180E52A60

	// Methods
	protected override void Setup(); // 0x0000000180E52650-0x0000000180E52830
	protected override void Start(); // 0x0000000180E52850-0x0000000180E528F0
	private void OnDestroy(); // 0x0000000180E52240-0x0000000180E522D0
	private void OnNotificationSent(NotificationSentMessage inMessage); // 0x0000000180E522D0-0x0000000180E52370
	protected override void PostListFilter(int inShownItemsCount); // 0x0000000180E52370-0x0000000180E523D0
	private void RefreshAllCaughtUpGroup(int inFrameDelay = 1 /* Metadata: 0x00782D93 */); // 0x0000000180E523D0-0x0000000180E52650
	protected override List<Notification> GetDataItems(); // 0x00000001803BD370-0x00000001803BD380
	protected override UI_LazyListItemDetailPanel<Notification> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<Notification> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(Notification inData); // 0x0000000180E52210-0x0000000180E52240
	protected override long GetDataItemAge(Notification inData); // 0x0000000180E521F0-0x0000000180E52210
	protected override void SortData(); // 0x0000000180E52830-0x0000000180E52850
	protected override LazyLayoutInfo CreateLayoutInfo(Notification inItem); // 0x0000000180E52120-0x0000000180E521F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshAllCaughtUpGroup>b__12_0(); // 0x0000000180E528F0-0x0000000180E52A20
}

