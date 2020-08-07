/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InventoryHelperManager : SingletonManagerBase<InventoryHelperManager> // TypeDefIndex: 12235
{
	// Fields
	private List<Item> _unreadItems; // 0x60

	// Properties
	public List<Item> UnreadItems { get; } // 0x0000000180418970-0x0000000180418980 

	// Constructors
	public InventoryHelperManager(); // 0x000000018062B8A0-0x000000018062B910

	// Methods
	public override void Init(); // 0x000000018062B320-0x000000018062B480
	public override void Deinit(); // 0x000000018062B1C0-0x000000018062B320
	public void MarkItemAsRead(Item inItem); // 0x000000018062B4E0-0x000000018062B5B0
	public void MarkItemAsUnread(Item inItem); // 0x000000018062B5B0-0x000000018062B680
	public bool ItemIsUnread(Item inItem); // 0x000000018062B480-0x000000018062B4E0
	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x000000018062B680-0x000000018062B7C0
	private void OnInventoryItemRemoved(InventoryItemRemovedEvent inMessage); // 0x000000018062B7C0-0x000000018062B7E0
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x000000018062B7E0-0x000000018062B810
	private void OnQuestOpened(RequestQuestOpenSuccessMessage inMessage); // 0x000000018062B810-0x000000018062B8A0
}

