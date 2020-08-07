/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InventoryItemChangedEvent : Message, ITaggedMessage // TypeDefIndex: 12725
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly Item <Item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly Item <PreviousItemState>k__BackingField; // 0x20

	// Properties
	public Item Item { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	public Item PreviousItemState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180374AF0-0x0000000180374B00 

	// Constructors
	public InventoryItemChangedEvent(Item newItem, Item prevItem); // 0x00000001803FE830-0x00000001803FE870

	// Methods
	public string GetTag(); // 0x0000000180495520-0x0000000180495540
}

