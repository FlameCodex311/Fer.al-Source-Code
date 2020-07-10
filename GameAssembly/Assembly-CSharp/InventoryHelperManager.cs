/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InventoryHelperManager : SingletonManagerBase<InventoryHelperManager> // TypeDefIndex: 10725
{
	// Fields
	private List<Item> _unreadItems; // 0x60

	// Properties
	public List<Item> UnreadItems { get; } // 0x0000000180369B40-0x0000000180369B50 

	// Constructors
	public InventoryHelperManager(); // 0x0000000180F624C0-0x0000000180F62530

	// Methods
	public override void Init(); // 0x0000000180F61F20-0x0000000180F62080
	public override void Deinit(); // 0x0000000180F61DC0-0x0000000180F61F20
	public void MarkItemAsRead(Item inItem); // 0x0000000180F620E0-0x0000000180F621B0
	public void MarkItemAsUnread(Item inItem); // 0x0000000180F621B0-0x0000000180F62280
	public bool ItemIsUnread(Item inItem); // 0x0000000180F62080-0x0000000180F620E0
	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x0000000180F62280-0x0000000180F623C0
	private void OnInventoryItemRemoved(InventoryItemRemovedEvent inMessage); // 0x0000000180F623C0-0x0000000180F623F0
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x0000000180F623F0-0x0000000180F62430
	private void OnQuestOpened(RequestQuestOpenSuccessMessage inMessage); // 0x0000000180F62430-0x0000000180F624C0
}

