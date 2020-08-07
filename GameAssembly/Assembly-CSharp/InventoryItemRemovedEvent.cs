/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InventoryItemRemovedEvent : Message, ITaggedMessage // TypeDefIndex: 12724
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly Item <Item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <Quantity>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsFullyRemoved>k__BackingField; // 0x24

	// Properties
	public Item Item { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	public int Quantity { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FB670-0x00000001803FB680 
	public bool IsFullyRemoved { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804F2E90-0x00000001804F2EA0 0x00000001804F2EA0-0x00000001804F2EB0

	// Constructors
	public InventoryItemRemovedEvent(Item item, int quantity, bool inIsFullyRemoved); // 0x000000018062BB00-0x000000018062BB50

	// Methods
	public string GetTag(); // 0x0000000180495520-0x0000000180495540
}

