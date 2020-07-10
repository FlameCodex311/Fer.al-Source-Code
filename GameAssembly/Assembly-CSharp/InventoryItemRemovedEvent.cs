/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InventoryItemRemovedEvent : Message, ITaggedMessage // TypeDefIndex: 11198
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly Item <Item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <Quantity>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsFullyRemoved>k__BackingField; // 0x24

	// Properties
	public Item Item { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	public int Quantity { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C2700-0x00000001803C2710 
	public bool IsFullyRemoved { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D80-0x0000000180487D90 0x00000001804884F0-0x0000000180488500

	// Constructors
	public InventoryItemRemovedEvent(Item item, int quantity, bool inIsFullyRemoved); // 0x0000000180F62760-0x0000000180F627B0

	// Methods
	public string GetTag(); // 0x00000001805A6C20-0x00000001805A6C40
}

