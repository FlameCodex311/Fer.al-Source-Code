/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InventoryItemChangedEvent : Message, ITaggedMessage // TypeDefIndex: 11199
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly Item <Item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly Item <PreviousItemState>k__BackingField; // 0x20

	// Properties
	public Item Item { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	public Item PreviousItemState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC70-0x000000018036AC80 

	// Constructors
	public InventoryItemChangedEvent(Item newItem, Item prevItem); // 0x0000000180EBFCE0-0x0000000180EBFD20

	// Methods
	public string GetTag(); // 0x00000001805A6C20-0x00000001805A6C40
}

